  Key Functional Areas and Business Logic:

1. Car Inventory and Management:
   
   - Entities: The system revolves around a Car entity (defined in `Car.cs` ), which stores details like make, model, year, number of doors, seats, transmission type, minimum age for rental, price per day, and availability status. Cars can also have associated images, likely managed by a CarImage model ( `CarImage.cs` ).
   - Administration: The `CarManagementController.cs` suggests an administrative interface (likely Views/CarManagement/Index.cshtml ) where authorized users can:
     - Add new cars to the inventory.
     - Edit details of existing cars.
     - Update car availability.
     - Manage car images.
2. User Interaction and Car Discovery (Frontend):
   
   - Homepage ( `HomeController.cs` , `Index.cshtml` ):
     - Displays a featured car with its specifications and a "Rent Now" option.
     - Provides a prominent search form allowing users to specify:
       - Pickup Location
       - Drop-off Location
       - Journey (Pickup) Date
       - Return Date
     - This form submits to the `CarsController.cs` to find matching vehicles.
     - Showcases a carousel of "Our Offer" cars with details and "Rent Now" buttons.
     - Indicates the total number of cars available.
   - Car Listings ( `CarsController.cs` , Views/Cars/Index.cshtml ):
     - Displays a list of cars, either all available or filtered by the user's search criteria from the homepage.
     - Users can view details of each car and initiate the rental process.
3. Rental and Booking Process:
   
   - Entities: A Rental model ( `Rental.cs` ) is central to this process. It would typically store:
     - User ID (linking to the User who made the booking).
     - Car ID (linking to the rented Car ).
     - Pickup and Drop-off locations and dates/times.
     - Total rental price.
     - Booking status (e.g., Pending, Confirmed, Completed, Cancelled).
   - Logic Flow:
     1. Selection: User selects a car and desired rental period.
     2. Availability Check: The system verifies if the chosen car is available for the specified dates and locations. This involves checking the IsAvailable flag on the Car and cross-referencing existing Rental records.
     3. Price Calculation: The total rental cost is calculated based on the car's PricePerDay and the duration of the rental.
     4. User Authentication/Details: The "Rent Now" buttons often redirect to /Account (handled by `AccountController.cs` or `LoginController.cs` ). This implies users need to register or log in before finalizing a booking. The User model ( `User.cs` ) stores user information.
     5. Confirmation & Payment (Inferred): After user authentication and providing necessary details, the booking is confirmed. This step would typically involve creating a new Rental record in the database. Payment processing logic might also be integrated here, although specific payment controllers are not immediately visible in the file list.
     6. Inventory Update: Once a car is booked, its IsAvailable status might be updated, or the system relies on checking rental records for availability.
4. User Account Management:
   
   - Controllers: `AccountController.cs` and `LoginController.cs` .
   - Functionality:
     - User registration and login.
     - Password management.
     - Viewing and managing their profile.
     - Viewing their rental history.
5. Supporting Functionalities:
   
   - Static Content Pages:
     - About Us ( `AboutController.cs` , Views/About/Index.cshtml ).
     - Contact Information ( `ContactController.cs` , Views/Contact/Index.cshtml ).
     - Services Offered ( `ServicesController.cs` , Views/Services/Index.cshtml ). The homepage also lists services like "Repair," "Car Accessories," and "Own a Car," though the primary focus is rentals.
   - "How It Works" Guide: The homepage outlines a 5-step process for renting a car: Time & Place, Car, Details, Checkout, Done.
6. Data Persistence:
   
   - The `ApplicationDbContext.cs` indicates the use of Entity Framework Core for interacting with a database. This context class would define DbSet properties for Car , Rental , User , CarImage , and any other persistent entities, managing how data is stored and retrieved.
Business Rules (Inferred):

- Users must meet the MinimumAge requirement for a specific car.
- Rental prices are fixed per day for each car.
- Users must typically be registered and logged in to make a booking.
- Pickup and drop-off locations are predefined (cities in Azerbaijan as per Index.cshtml ).
