<h1>📱 ASP.NET MVC Web API for Device Management</h1>
<p>This project is an ASP.NET MVC Web API designed to efficiently manage devices and their specifications. It offers full CRUD operations (Create, Read, Update, Delete) on devices, providing a robust solution for handling device data and their associated specifications through a master-detail relationship.</p>

<h2>🌟 Features</h2>
<ul>
    <li><strong>Device Management:</strong> Add, edit, view, and delete device details including name, release date, price, picture, and sale status.</li>
    <li><strong>Specifications Management:</strong> Each device can have a list of specifications, such as technical attributes or product features, which can be dynamically added or removed.</li>
    <li><strong>Image Upload:</strong> Supports uploading images for devices via a dedicated API endpoint.</li>
    <li><strong>Master-Detail Relationship:</strong> Ensures smooth management of devices and their associated specs in a single workflow.</li>
    <li><strong>Database Integration:</strong> Utilizes Entity Framework for efficient database operations and relationships.</li>
    <li><strong>Validation:</strong> Implements data validation using annotations like Required and StringLength to ensure data integrity.</li>
</ul>

<h2>🛠 Technologies</h2>
<ul>
    <li><strong>ASP.NET MVC Web API:</strong> Provides API endpoints for managing devices and specifications.</li>
    <li><strong>Entity Framework:</strong> Manages database interactions and relationships.</li>
    <li><strong>SQL Server:</strong> Serves as the database backend.</li>
    <li><strong>C#:</strong> Core programming language for API logic.</li>
    <li><strong>HTML/CSS/JavaScript:</strong> Can be used for frontend integration for a complete solution.</li>
    <li><strong>File Upload:</strong> Allows image uploading for devices, stored in a specified server directory.</li>
</ul>

<h2>🚀 API Endpoints</h2>
<ul>
    <li><strong>GET /api/Devices:</strong> Retrieve all devices with their specifications.</li>
    <li><strong>GET /api/Devices/{id}:</strong> Retrieve a specific device by its ID.</li>
    <li><strong>POST /api/Devices:</strong> Add a new device with associated specs.</li>
    <li><strong>PUT /api/Devices/{id}:</strong> Update an existing device and its specs.</li>
    <li><strong>DELETE /api/Devices/{id}:</strong> Delete a device by its ID.</li>
    <li><strong>POST /Image/Upload:</strong> Upload an image for a device.</li>
</ul>

<p>This project is ideal for implementing a master-detail relationship in ASP.NET using Web API and includes comprehensive documentation and examples for ease of use. 🌟</p>
