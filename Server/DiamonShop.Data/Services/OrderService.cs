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
                OrderStatus = OrderStatus.WatingConfirm,
                Phone = request.Phone,
                Status = true,
                PaymentMethod = request.PaymentMethod,
                ReceiptDay = request.ReceiptDay,
            };
            _repositoryManager.Order.Add(order);
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

        public async Task<IEnumerable<OrderResponse>> GetAllOrders()
        {
            var orders = await _repositoryManager.Order.GetAllOrderAsync();

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
