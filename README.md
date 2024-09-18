<h1>TestCoreApi2 Project</h1>

<h2>Project Overview</h2>
<p>The <strong>TestCoreApi2</strong> project is an ASP.NET Core Web API that serves as a simple example for creating, retrieving, and managing product data. It demonstrates the use of ASP.NET Core features such as routing, dependency injection, Entity Framework Core for database operations, and asynchronous programming. The project is designed to fetch products from a database and filter them based on parameters such as category and price.</p>

<h2>Main Features</h2>
<p>
    <ul>
        <li><strong>RESTful API:</strong> The project follows the REST architecture, providing GET endpoints to fetch product data.</li>
        <li><strong>Database Integration:</strong> Entity Framework Core is used to interact with the database, making it easy to perform CRUD operations on the products.</li>
        <li><strong>Asynchronous Programming:</strong> All database operations are asynchronous, ensuring non-blocking code execution and better performance.</li>
        <li><strong>Parameterized Routing:</strong> The API supports routes that allow filtering of products based on category and minimum price.</li>
    </ul>
</p>

<h2>Endpoints</h2>
<h3>1. GET: Fetch All Products</h3>
<p>This endpoint retrieves all products from the database and returns them as a list. It's designed to allow easy access to the full collection of products available in the system.</p>

<h3>2. GET: Fetch Products by Category and Price</h3>
<p>This endpoint allows clients to filter products by category and a minimum price. The route parameters are used to specify the desired category and price filter.</p>

<h2>Technologies Used</h2>
<p>
    <ul>
        <li><strong>ASP.NET Core:</strong> The foundation for building the Web API, providing powerful tools for handling HTTP requests and responses.</li>
        <li><strong>Entity Framework Core:</strong> An Object-Relational Mapper (ORM) that simplifies database interactions, allowing developers to work with databases using .NET objects.</li>
        <li><strong>Dependency Injection:</strong> The project makes use of ASP.NET Core's built-in dependency injection to manage services such as the application's database context.</li>
    </ul>
</p>

<h2>Future Enhancements</h2>
<p>
    <ul>
        <li><strong>Additional CRUD Operations:</strong> Add POST, PUT, and DELETE endpoints to allow full management of product data.</li>
        <li><strong>Pagination:</strong> Implement pagination to handle large sets of product data efficiently, returning data in smaller chunks.</li>
        <li><strong>Authentication:</strong> Introduce authentication to secure the API and control access to product data.</li>
    </ul>
</p>

<h2>Conclusion</h2>
<p>The <strong>TestCoreApi2</strong> project is a simple yet powerful API designed to demonstrate key concepts in ASP.NET Core development, such as routing, database integration, and asynchronous programming. It provides a solid foundation for building more complex APIs that require product management and filtering capabilities.</p>
