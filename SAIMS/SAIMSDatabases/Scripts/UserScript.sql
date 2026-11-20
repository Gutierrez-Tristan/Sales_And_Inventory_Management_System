/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Users (Username, Password, Role) VALUES ('admin', 'admin123', 'Admin');
INSERT INTO Users (Username, Password, Role) VALUES ('cashier', 'cashier123', 'Cashier');

/*
Post-Deployment Script Template
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
 Use SQLCMD syntax to include a file in the post-deployment script.
 Example:      :r .\myfile.sql
 Use SQLCMD syntax to reference a variable in the post-deployment script.
 Example:      :setvar TableName MyTable
               SELECT * FROM [$(TableName)]
--------------------------------------------------------------------------------------
*/
/*
 Seed data: 14 categories, 11 suppliers, 37 items (every category has items).
 Safe to run repeatedly.
*/

-- ============ CATEGORIES ============
DECLARE @Categories TABLE (Name VARCHAR(100));

INSERT INTO @Categories (Name) VALUES
('Batteries'), ('Paper'), ('Packaging'), ('Electrical'), ('Lighting'),
('Tools'), ('Safety'), ('Network'), ('Barcode'), ('Shelving'),
('Office Supplies'), ('Cleaning'), ('Plumbing'), ('Fasteners');

INSERT INTO tblCategory (Name)
SELECT c.Name
FROM @Categories c
WHERE NOT EXISTS (SELECT 1 FROM tblCategory x WHERE x.Name = c.Name);

-- ============ SUPPLIERS ============
DECLARE @Suppliers TABLE
(
    Name VARCHAR(100), Email VARCHAR(100), Phone VARCHAR(20), Address VARCHAR(200)
);

INSERT INTO @Suppliers (Name, Email, Phone, Address) VALUES
('Pasay Batteries',         'pasaybatteries@gmail.com',       '09171234567', 'Pasay City'),
('Bataan Paper',            'bataanpaper@gmail.com',          '09881234567', 'Bataan'),
('Cavite Packaging',        'cavitepackaging@gmail.com',      '09782202749', 'Dasmarinas, Cavite'),
('Batangas Electrical',     'batangaselectrical@gmail.com',   '09046447990', 'Batangas City'),
('Valenzuela Electrical',   'valenzuelaelectrical@gmail.com', '09175550142', 'Valenzuela City'),
('IronWorks Hardware',      'ironworks@gmail.com',            '09283344556', 'Quezon City'),
('Bataan Safety',           'bataansafety@gmail.com',         '09776106553', 'Mariveles, Bataan'),
('Alabang Network',         'alabangnetwork@gmail.com',       '09675446545', 'Alabang, Muntinlupa'),
('Barcode Solutions',       'barcodesolutions@gmail.com',     '09176617120', 'Makati City'),
('Rizal Steel',             'rizalsteel@gmail.com',           '09357781230', 'Cainta, Rizal'),
('Manila Janitorial Supply','manilajanitorial@gmail.com',     '09189997766', 'Manila');

INSERT INTO tblSuppliers (Name, Email, Phone, Address)
SELECT t.Name, t.Email, t.Phone, t.Address
FROM @Suppliers t
WHERE NOT EXISTS (SELECT 1 FROM tblSuppliers s WHERE s.Name = t.Name);

-- ============ SUPPLIER PRODUCTS (with category) ============
DECLARE @Items TABLE
(
    SupplierName VARCHAR(100),
    CategoryName VARCHAR(100),
    ItemName     VARCHAR(100),
    UnitPrice    DECIMAL(10,2),
    Stock        INT
);

INSERT INTO @Items (SupplierName, CategoryName, ItemName, UnitPrice, Stock) VALUES
('Pasay Batteries',         'Batteries',       'AA Battery',            400.00,  500),
('Pasay Batteries',         'Batteries',       'AAA Battery',           380.00,  350),
('Pasay Batteries',         'Batteries',       'Rechargeable Battery',  650.00,  120),
('Bataan Paper',            'Paper',           'Copy Paper',            210.00,  200),
('Bataan Paper',            'Paper',           'Bond Paper',            240.00,  150),
('Cavite Packaging',        'Packaging',       'Bubble Wrap',           520.00,   80),
('Cavite Packaging',        'Packaging',       'Packing Tape',           35.00,  600),
('Cavite Packaging',        'Packaging',       'Carton Box',             22.00, 1000),
('Batangas Electrical',     'Electrical',      'Circuit Breaker',       210.00,   90),
('Batangas Electrical',     'Electrical',      'Electrical Wire',      1850.00,   40),
('Valenzuela Electrical',   'Electrical',      'Extension Cord',        240.00,  100),
('Valenzuela Electrical',   'Electrical',      'Surge Protector',       380.00,   60),
('Valenzuela Electrical',   'Lighting',        'LED Bulb',               55.00,  300),
('IronWorks Hardware',      'Tools',           'Hammer',                200.00,   70),
('IronWorks Hardware',      'Tools',           'Screwdriver Set',       320.00,   45),
('Bataan Safety',           'Safety',          'Safety Gloves',         105.00,  150),
('Bataan Safety',           'Safety',          'Safety Helmet',         180.00,   80),
('Bataan Safety',           'Safety',          'Safety Goggles',         95.00,  120),
('Alabang Network',         'Network',         'Ethernet Cable',       3600.00,   15),
('Alabang Network',         'Network',         'RJ45 Connector',        250.00,   60),
('Barcode Solutions',       'Barcode',         'Barcode Scanner',      1450.00,   25),
('Barcode Solutions',       'Barcode',         'Barcode Label',          80.00,  200),
('Barcode Solutions',       'Paper',           'Receipt Paper',          25.00,  500),
('Rizal Steel',             'Shelving',        'Steel Rack',           2600.00,   20),
('Rizal Steel',             'Shelving',        'Wire Rack',            1800.00,   15),
-- categories that previously had no items
('Bataan Paper',            'Office Supplies', 'Ballpen (Box)',         120.00,  200),
('Bataan Paper',            'Office Supplies', 'Stapler',               150.00,   50),
('Bataan Paper',            'Office Supplies', 'Folder (Pack)',          90.00,  150),
('Manila Janitorial Supply','Cleaning',        'Disinfectant Spray',     95.00,  100),
('Manila Janitorial Supply','Cleaning',        'Floor Mop',             180.00,   40),
('Manila Janitorial Supply','Cleaning',        'Trash Bags (Roll)',      60.00,  250),
('IronWorks Hardware',      'Plumbing',        'PVC Pipe',              140.00,   80),
('IronWorks Hardware',      'Plumbing',        'Water Faucet',          260.00,   40),
('IronWorks Hardware',      'Plumbing',        'Teflon Tape',            18.00,  300),
('Rizal Steel',             'Fasteners',       'Steel Screws (Box)',    110.00,  200),
('Rizal Steel',             'Fasteners',       'Nails (Kg)',             85.00,  150),
('Rizal Steel',             'Fasteners',       'Bolts and Nuts Set',    170.00,   90);

INSERT INTO tblSupplierProduct (SupplierID, CategoryID, ItemName, UnitPrice, Stock)
SELECT s.SupplierID, c.CategoryID, i.ItemName, i.UnitPrice, i.Stock
FROM @Items i
JOIN tblSuppliers s ON s.Name = i.SupplierName
JOIN tblCategory  c ON c.Name = i.CategoryName
WHERE NOT EXISTS (SELECT 1
                  FROM tblSupplierProduct sp
                  WHERE sp.SupplierID = s.SupplierID
                    AND sp.ItemName   = i.ItemName);

-- =====================================================================
-- MORE SUPPLIERS (not in the store yet) + NEW CATEGORIES
-- =====================================================================

-- ============ NEW CATEGORIES ============
DECLARE @NewCategories TABLE (Name VARCHAR(100));

INSERT INTO @NewCategories (Name) VALUES
('Printing'), ('Computer Accessories'), ('Storage Media'), ('Pantry');

INSERT INTO tblCategory (Name)
SELECT c.Name
FROM @NewCategories c
WHERE NOT EXISTS (SELECT 1 FROM tblCategory x WHERE x.Name = c.Name);

-- ============ NEW SUPPLIERS ============
DECLARE @NewSuppliers TABLE
(
    Name VARCHAR(100), Email VARCHAR(100), Phone VARCHAR(20), Address VARCHAR(200)
);

INSERT INTO @NewSuppliers (Name, Email, Phone, Address) VALUES
('Divisoria Computer Hub',  'divisoriacomputer@gmail.com',  '09175551001', 'Divisoria, Manila'),
('Quezon Printing Supplies','quezonprinting@gmail.com',     '09175551002', 'Quezon City'),
('Cebu Storage Depot',      'cebustorage@gmail.com',        '09175551003', 'Cebu City'),
('Laguna Office Mart',      'lagunaoffice@gmail.com',       '09175551004', 'Santa Rosa, Laguna'),
('Davao Pantry Wholesale',  'davaopantry@gmail.com',        '09175551005', 'Davao City');

INSERT INTO tblSuppliers (Name, Email, Phone, Address)
SELECT t.Name, t.Email, t.Phone, t.Address
FROM @NewSuppliers t
WHERE NOT EXISTS (SELECT 1 FROM tblSuppliers s WHERE s.Name = t.Name);

-- ============ NEW SUPPLIER PRODUCTS (with category) ============
DECLARE @NewItems TABLE
(
    SupplierName VARCHAR(100),
    CategoryName VARCHAR(100),
    ItemName     VARCHAR(100),
    UnitPrice    DECIMAL(10,2),
    Stock        INT
);

INSERT INTO @NewItems (SupplierName, CategoryName, ItemName, UnitPrice, Stock) VALUES
('Divisoria Computer Hub',  'Computer Accessories', 'Wireless Mouse',          350.00,  80),
('Divisoria Computer Hub',  'Computer Accessories', 'USB Keyboard',            480.00,  60),
('Divisoria Computer Hub',  'Computer Accessories', 'Webcam',                  890.00,  30),
('Quezon Printing Supplies','Printing',             'Ink Cartridge Black',     520.00, 100),
('Quezon Printing Supplies','Printing',             'Toner Cartridge',        1850.00,  25),
('Quezon Printing Supplies','Printing',             'Printer Ribbon',          310.00,  70),
('Cebu Storage Depot',      'Storage Media',        'USB Flash Drive 16GB',    220.00, 150),
('Cebu Storage Depot',      'Storage Media',        'SD Card 32GB',            260.00, 120),
('Laguna Office Mart',      'Office Supplies',      'Whiteboard Marker (Box)', 160.00,  90),
('Laguna Office Mart',      'Office Supplies',      'Masking Tape',             28.00, 300),
('Laguna Office Mart',      'Paper',                'Sticky Notes',             45.00, 200),
('Davao Pantry Wholesale',  'Pantry',               'Instant Coffee (Box)',    240.00,  60),
('Davao Pantry Wholesale',  'Pantry',               'Bottled Water (Case)',    190.00,  80),
('Davao Pantry Wholesale',  'Pantry',               'Paper Cups (Pack)',        75.00, 150);

INSERT INTO tblSupplierProduct (SupplierID, CategoryID, ItemName, UnitPrice, Stock)
SELECT s.SupplierID, c.CategoryID, i.ItemName, i.UnitPrice, i.Stock
FROM @NewItems i
JOIN tblSuppliers s ON s.Name = i.SupplierName
JOIN tblCategory  c ON c.Name = i.CategoryName
WHERE NOT EXISTS (SELECT 1
                  FROM tblSupplierProduct sp
                  WHERE sp.SupplierID = s.SupplierID
                    AND sp.ItemName   = i.ItemName);