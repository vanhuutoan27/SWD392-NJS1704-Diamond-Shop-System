using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Core.Shared.Enum;

namespace DiamonShop.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> ChangeOrderStatusAsync(ChangeOrderStatusRequest request)
        {
            var order = await _repositoryManager.Order.GetOrderByIdAsync(request.OrderId);
            if (order == null)
            {
                return false;
            }
            if (request.orderStatus.Equals(order.OrderStatus))
            {
                return false;
            }
            switch (request.orderStatus)
            {
                case OrderStatus.Pending:
                    order.OrderStatus = OrderStatus.Pending;
                    break;
                case OrderStatus.Processing:
                    order.OrderStatus = OrderStatus.Processing;

                    break;
                case OrderStatus.Shipping:
                    order.OrderStatus = OrderStatus.Shipping;

                    break;
                case OrderStatus.Cancelled:
                    order.OrderStatus = OrderStatus.Cancelled;

                    break;
                case OrderStatus.Completed:
                    order.OrderStatus = OrderStatus.Completed;

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(request.orderStatus), request.orderStatus, null);
            }
            _repositoryManager.Order.Update(order);
            await _repositoryManager.SaveAsync();
            return true;



        }

        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            Order order = new Order()
            {
                Total = request.Total,
                CustomerId = request.CustomerId,
                DateCreated = DateTime.Now,
                Address = request.Address,
                CustomerName = request.CustomerName,
                Email = request.Email,
                Note = request.Note == null ? "" : request.Note,
                OrderStatus = OrderStatus.Pending,
                Phone = request.Phone,
                Status = true,
                PaymentMethod = request.PaymentMethod,
                ReceiptDay = request.ReceiptDay,
                Discount = request.Discount,
            };
            _repositoryManager.Order.Add(order);
            //add invoice 

            Invoice invoice = new Invoice()
            {
                UserId = request.CustomerId,
                OrderId = order.OrderId,
                CreateDate = DateTime.Now,
                StatusInvoice = InvoiceStatus.Paid,
            };
            _repositoryManager.Invoice.Add(invoice);

            //add detail product
            foreach (var item in request.Products)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = order.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    DateCreated = DateTime.Now,
                    Status = true,
                    UnitPrice = item.UnitPrice,
                };
                _repositoryManager.OrderItems.Add(orderItem);
            }
            await _repositoryManager.SaveAsync();
            return new CreateOrderResponse() { OrderId = order.OrderId };
        }

        public async Task DeleteOrder(Guid id)
        {
            var order = await _repositoryManager.Order.GetByIdAsync(id);
            if (order == null)
            {
                throw new Exception("Not Found Order");
            }

            _repositoryManager.Order.Remove(order);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<OrderResponse>> GetAllOrders()
        {
            var orders = await _repositoryManager.Order.GetAllOrderAsync();

            return _mapper.Map<IEnumerable<OrderResponse>>(orders);
        }

        public async Task<IEnumerable<OrderResponse>> GetOrderByCustomerIdAsync(Guid id)
        {
            var orders = await _repositoryManager.Order.GetOrderByCustomerIdAsync(id);
            if (orders == null || !orders.Any())
            {
                throw new Exception("Not Found By Customer Id");

            }
            return _mapper.Map<IEnumerable<OrderResponse>>(orders);
        }

        public async Task<OrderResponse> GetOrderByIdAsync(Guid id)
        {
            var order = await _repositoryManager.Order.GetOrderByIdAsync(id);
            if (order == null)
            {
                throw new Exception("Not Found Order");
            }
            return _mapper.Map<OrderResponse>(order);
        }
    }
}
