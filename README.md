
# DIAMOON - Diamond Shop System

This project is a comprehensive diamond sales management system designed for an online diamond trading company. The system is built using modern technologies including ReactJS, TypeScript, TailwindCSS, ShadCN for the Frontend, and ASP.NET Core Web API with SQL Server for the Backend.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Home Page:** Introduction to the store, product collections, diamond price list, jewelry knowledge, diamond selection guide, FAQ, and more.
- **Customer Management:** Track customer purchase history.
  - Customer selects a product and places an order.
  - Sales staff receive the order and guide customers on ring size measurement.
  - Customer confirms the ring size and makes the payment.
  - Sales staff ship the product with a warranty card and diamond certification.
  - Delivery staff send the product to the customer.
- **Warranty Management:** Manage product warranty cards and diamond certificates according to GIA's 4C standards.
- **Promotions and Loyalty Points:** Manage promotional programs and accumulate points.
- **Pricing Management:** Declare diamond prices based on origin, carat weight, color, clarity, and cut; declare diamond shell prices.
- **Product Management:** Manage diamond products including shells, main diamonds, and secondary diamonds.
- **Sales Dashboard:** Statistical dashboard for sales tracking.

## Technologies Used

### Frontend
- **ReactJS**: JavaScript library for building user interfaces
- **TypeScript**: Superset of JavaScript that adds static typing
- **TailwindCSS**: Utility-first CSS framework
- **ShadCN**: Styling solution for consistent theming

### Backend
- **ASP.NET Core Web API**: Framework for building web APIs
- **SQL Server**: Relational database management system

## Installation

### Prerequisites

- **Node.js** (for Frontend)
- **.NET 8 SDK** (for Backend)
- **SQL Server** (for database)

### Frontend

1. Clone the repository:
   ```sh
   git clone https://github.com/vanhuutoan27/SWD392-NJS1704-Diamond-Shop-System.git
   ```
   
   ```sh
   cd Client
   ```

2. Install dependencies:
   ```sh
   npm install
   ```

3. Run the development server:
   ```sh
   npm run dev
   ```

### Backend

1. Navigate to the Backend directory:
   ```sh
   cd Server
   ```

2. Restore packages:
   ```sh
   dotnet restore
   ```

3. Update the connection string in \`appsettings.json\` to point to your SQL Server instance.

4. Run the Backend server:
   ```sh
   dotnet run
   ```

## Usage

1. Open your browser and navigate to \`http://localhost:1412\` to access the Frontend.
2. Use the API endpoints from the Backend for data operations.

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch: \`git checkout -b feature-name\`.
3. Make your changes and commit them: \`git commit -m 'Add feature-name'\`.
4. Push to the branch: \`git push origin feature-name\`.
5. Open a pull request on GitHub.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
