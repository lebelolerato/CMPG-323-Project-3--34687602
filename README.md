# CMPG-323-Project-3--34687602
Repository patterns Implementation

## How my project works
    For this project I implemented Tier 2 which is the advanced level of the Repository patterns. I started by creating Repositories folder which contains my Generic,
    Category, Device and Zone repository classes and interfaces
    
    ### Repository Folder
    
          1. CategoryRepository class == contain all data access operations relating to Categories
          2. DeviceRepository class == contain all data access operations relating to Devices 
          3. ZoneRepository class == contain all data access operations relating to Zones
          4. GenericRepository class == contains all methods used to manipulate data in your tables
    
          In my interfaces(IZone, IDevice and ICategory) I will add any additional methods I created and they will be inherited by my Repository classes. CategoryRepository,
          DeviceRepository and ZoneRepository will inherit the GenericRepository so that I can be able to acces the methods.
          
    
    ### Controllers
    
          In my controller folder I have 4 controller classes namely 
            1. DevicesContorller == Contains data access operations for the Device table
            2. CategoriesController == Contains data access operations for the Category table
            3. ZonesController == Contains data access operations for the Zone table
            4. HomeController == Contains data access operations to all the available tables (Category, Device, Zone tables)
            
 So what I did was I transfered all data access operations from DeviceRepository to the DevicesController, from the CategoryRepository to the CategoriesController class,
 and from the ZoneRepository to the ZonesController class so that when I wanna edit my methods I only edit from one file which the GenericRepository class. I implemented the
 use of the DeviceRepository class in the DevicesController. Then I implemented the use of the ZoneRepository class in the ZonesController. And I also implemented the use of
 the CategoryRepository class in the CategoriesController.
    
    
    
