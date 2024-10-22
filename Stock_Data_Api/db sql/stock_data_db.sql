--CREATE DATABASE STOCK_DATA;
USE STOCK_DATA;
-- Create Address Table
CREATE TABLE s_address (
    id INT PRIMARY KEY,
    country VARCHAR(255),
    address_line_1 VARCHAR(255),
    address_line_2 VARCHAR(255),
    city VARCHAR(255),
    state VARCHAR(255),
    postal_code VARCHAR(20),
    phone_number VARCHAR(20),
    fax VARCHAR(20)
);

-- Create Currency Table
CREATE TABLE currency (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    description VARCHAR(255)
);

-- Create Tax Table
CREATE TABLE tax (
    id INT PRIMARY KEY,
    title VARCHAR(50),
    ratio DECIMAL(5, 2)
);

-- Create Payment Conditions Table
CREATE TABLE payment_conditions (
    id INT PRIMARY KEY,
    label VARCHAR(255)
);

-- Create Associated Docs Table
CREATE TABLE associated_docs (
    id INT PRIMARY KEY,
    -- Add necessary columns for associated documents
    -- (e.g., document_title, document_date, etc.)
);

-- Create Associated Docs Files Table
CREATE TABLE associated_docs_files (
    id INT PRIMARY KEY,
    associated_docs_id INT,
    file_path VARCHAR(255),
    -- Add necessary columns for file details (e.g., file_name, file_type, etc.)
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Seller Table
CREATE TABLE seller (
    id INT PRIMARY KEY,
    full_name VARCHAR(255)
);

-- Create Unit Table
CREATE TABLE unit (
    id INT PRIMARY KEY,
    label VARCHAR(255)
);

-- Create Manufacturer Table
CREATE TABLE manufacturer (
    id INT PRIMARY KEY,
    name VARCHAR(255)
);

-- Create Dimension Table
CREATE TABLE dimension (
    id INT PRIMARY KEY,
    width FLOAT,
    length FLOAT,
    height FLOAT
);

-- Create Person to Contact Table
CREATE TABLE person_to_contact (
    id INT PRIMARY KEY,
    title VARCHAR(10),
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    email VARCHAR(255),
    phone_number_pro VARCHAR(20),
    phone_number_portable VARCHAR(20),
    department VARCHAR(255),
    designation VARCHAR(255)
);

-- Create Payment Mode Table
CREATE TABLE payment_mode (
    id INT PRIMARY KEY,
    label VARCHAR(255),
    description VARCHAR(255)
);

-- Create Client Table
CREATE TABLE client (
    id INT PRIMARY KEY,
    title VARCHAR(10),
    first_name VARCHAR(255),
    last_name VARCHAR(255),
	company_name VARCHAR(255),
    type VARCHAR(20),
    display_name VARCHAR(255), 
    email VARCHAR(255),
    phone_pro VARCHAR(20),
    phone_portable VARCHAR(20),
    note TEXT,
    billing_address_id INT,
    delivery_address_id INT,
    currency_id INT,
    tax_id INT,
    payment_cdt_id INT,
    associated_docs_id INT,
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (currency_id) REFERENCES currency(id),
    FOREIGN KEY (tax_id) REFERENCES tax(id),
    FOREIGN KEY (payment_cdt_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Client Table
CREATE TABLE supplier (
    id INT PRIMARY KEY,
    title VARCHAR(10),
    first_name VARCHAR(255),
    last_name VARCHAR(255),
	company_name VARCHAR(255),
    type VARCHAR(20),
    display_name VARCHAR(255), 
    email VARCHAR(255),
    phone_pro VARCHAR(20),
    phone_portable VARCHAR(20),
    note TEXT,
    billing_address_id INT,
    delivery_address_id INT,
    currency_id INT,
    tax_id INT,
    payment_cdt_id INT,
    associated_docs_id INT,
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (currency_id) REFERENCES currency(id),
    FOREIGN KEY (tax_id) REFERENCES tax(id),
    FOREIGN KEY (payment_cdt_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Banks Table
CREATE TABLE banks (
    id INT PRIMARY KEY,
    bank_name VARCHAR(255) NOT NULL,
    branch_name VARCHAR(255) NOT NULL,
    image_path VARCHAR(255)
);

-- Create Cheques Table
CREATE TABLE cheques (
    id INT PRIMARY KEY,
    cheque_number VARCHAR(20) NOT NULL,
    account_holder_name VARCHAR(255) NOT NULL,
    account_number VARCHAR(20) NOT NULL,
    bank_id INT, -- Foreign key of banks
    amount DECIMAL(15, 2) NOT NULL,
    payee_name VARCHAR(255) NOT NULL,
	currency_id INT, -- Foreign key of currency
    issue_date DATE NOT NULL,
    payment_date DATE NOT NULL,
    memo TEXT,
    image_path VARCHAR(255),
    state VARCHAR(20) CHECK (state IN ('accepted', 'refused', 'not checked')),
	FOREIGN KEY (currency_id) REFERENCES currency(id),
    CONSTRAINT fk_bank FOREIGN KEY (bank_id) REFERENCES banks(id),
    CONSTRAINT chk_cheque_number_length CHECK (LEN(cheque_number) <= 20)
);


-- Create Payment Sell Table
CREATE TABLE payment_sell (
    id INT PRIMARY KEY,
    n_payment VARCHAR(255),
    client_id INT, -- Foreign key of client
    bank_charges DECIMAL(15, 2),
    payment_date DATE,
    n_reference VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    comment TEXT,
    FOREIGN KEY (client_id) REFERENCES client(id),
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Payment of Mode Sell Table
CREATE TABLE payment_of_mode_sell (
    id INT PRIMARY KEY,
    payment_mode_id INT, -- Foreign key of payment_mode
    amount DECIMAL(15, 2),
    currency_id INT, -- Foreign key of currency
    payment_sell_id INT, -- Foreign key of payment_sell
	associated_docs_id INT, -- Foreign key of associated_docs
    FOREIGN KEY (payment_mode_id) REFERENCES payment_mode(id),
    FOREIGN KEY (currency_id) REFERENCES currency(id),
    FOREIGN KEY (payment_sell_id) REFERENCES payment_sell(id),
	FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Cheque of Mode Sell Table
CREATE TABLE cheque_of_mode_sell (
    id INT PRIMARY KEY,
    cheque_id INT, -- Foreign key of payment_mode
    payment_sell_id INT, -- Foreign key of payment_sell
	associated_docs_id INT, -- Foreign key of associated_docs
    FOREIGN KEY (cheque_id) REFERENCES cheques(id),
    FOREIGN KEY (payment_sell_id) REFERENCES payment_sell(id),
	FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Payment Sell Table
CREATE TABLE payment_import (
    id INT PRIMARY KEY,
    n_payment VARCHAR(255),
    supplier_id INT, -- Foreign key of client
    bank_charges DECIMAL(15, 2),
    payment_date DATE,
    n_reference VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    comment TEXT,
    FOREIGN KEY (supplier_id) REFERENCES supplier(id),
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Payment of Mode Sell Table
CREATE TABLE payment_of_mode_import (
    id INT PRIMARY KEY,
    payment_mode_id INT, -- Foreign key of payment_mode
    amount DECIMAL(15, 2),
    currency_id INT, -- Foreign key of currency
    payment_import_id INT, -- Foreign key of payment_sell
	associated_docs_id INT,
    FOREIGN KEY (payment_mode_id) REFERENCES payment_mode(id),
    FOREIGN KEY (currency_id) REFERENCES currency(id),
    FOREIGN KEY (payment_import_id) REFERENCES payment_import(id),
	FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)

);

-- Create Cheque of Mode Sell Table
CREATE TABLE cheque_of_mode_import (
    id INT PRIMARY KEY,
    cheque_id INT, -- Foreign key of payment_mode
    payment_import_id INT, -- Foreign key of payment_sell
	associated_docs_id INT, -- Foreign key of associated_docs
    FOREIGN KEY (cheque_id) REFERENCES cheques(id),
    FOREIGN KEY (payment_import_id) REFERENCES payment_import(id),
	FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id)
);

-- Create Person Contacts Client Table
CREATE TABLE person_contacts_client (
    id INT PRIMARY KEY,
    person_to_contact_id INT, -- Foreign key of person_to_contact
    client_id INT, -- Foreign key of client
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (client_id) REFERENCES client(id)
);

-- Create Person Contacts Client Table
CREATE TABLE person_contacts_supplier (
    id INT PRIMARY KEY,
    person_to_contact_id INT, -- Foreign key of person_to_contact
    supplier_id INT, -- Foreign key of client
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (supplier_id) REFERENCES supplier(id)
);

-- Create Article Selling Info Table
CREATE TABLE article_selling_info (
    id INT PRIMARY KEY,
    price_per_unit DECIMAL(15, 2),
    account_id INT,
    description TEXT,
    tax_id INT, -- Foreign key of tax
    FOREIGN KEY (tax_id) REFERENCES tax(id)
);

-- Create Article Import Info Table
CREATE TABLE article_import_info (
    id INT PRIMARY KEY,
    price_per_unit DECIMAL(15, 2),
    account_id INT,
    description TEXT,
    tax_id INT, -- Foreign key of tax
    preferred_supplier_id INT, -- Foreign key of supplier
    FOREIGN KEY (tax_id) REFERENCES tax(id),
    FOREIGN KEY (preferred_supplier_id) REFERENCES supplier(id) -- Assuming a supplier table exists
);
CREATE TABLE delivery_mode (
	id INT PRIMARY KEY,
	label VARCHAR(255)
);
-- Create Article Table
CREATE TABLE articles_family (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    sku VARCHAR(255),
    unit_id INT, -- Foreign key of unit
    image_path VARCHAR(255),
    manufacturer_id INT, -- Foreign key of manufacturer
    UPC VARCHAR(255),
    is_returnable bit,
    EAN VARCHAR(255),
    dimension_id INT, -- Foreign key of dimension
    weight FLOAT,
    mpn VARCHAR(255),
    ISBN VARCHAR(255),
    sell_info_id INT, -- Foreign key of article_selling_info
    import_info_id INT, -- Foreign key of article_import_info
    account_id INT,
    type_article VARCHAR(20),
    follow_stock bit,
    FOREIGN KEY (unit_id) REFERENCES unit(id),
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(id),
    FOREIGN KEY (dimension_id) REFERENCES dimension(id),
    FOREIGN KEY (sell_info_id) REFERENCES article_selling_info(id),
    FOREIGN KEY (import_info_id) REFERENCES article_import_info(id)
);
-- Create Article Table
CREATE TABLE article (
    id INT PRIMARY KEY,
    articles_family_id INT, -- Foreign key of famille
    name VARCHAR(255),
    sku VARCHAR(255),
    unit_id INT, -- Foreign key of unit
    image_path VARCHAR(255),
    manufacturer_id INT, -- Foreign key of manufacturer
    UPC VARCHAR(255),
    is_returnable bit,
    EAN VARCHAR(255),
    dimension_id INT, -- Foreign key of dimension
    weight FLOAT,
    mpn VARCHAR(255),
    ISBN VARCHAR(255),
    sell_info_id INT, -- Foreign key of article_selling_info
    import_info_id INT, -- Foreign key of article_import_info
    account_id INT,
    follow_stock bit,
    FOREIGN KEY (articles_family_id) REFERENCES articles_family(id),
    FOREIGN KEY (unit_id) REFERENCES unit(id),
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(id),
    FOREIGN KEY (dimension_id) REFERENCES dimension(id),
    FOREIGN KEY (sell_info_id) REFERENCES article_selling_info(id),
    FOREIGN KEY (import_info_id) REFERENCES article_import_info(id)
);

-- Create Tab Articles Table
CREATE TABLE tab_articles (
    id INT PRIMARY KEY,
    subtotal DECIMAL(15, 2),
    personalized_r_name VARCHAR(255),
    personalized_r_amount DECIMAL(15, 2),
    shipping_costs DECIMAL(15, 2),
    total DECIMAL(15, 2),
	discount_total Float,
	discount_state VARCHAR(10) CHECK(discount_state IN('payed','not_payed')),
    is_article_visible bit,
    is_quantity_visible bit,
    is_unit_price_visible bit,
    is_discount_visible bit,
	is_item_total_visible bit

);

-- Create Tab Articles Vente Item Table
CREATE TABLE tab_articles_item (
    id INT PRIMARY KEY,
    article_id INT, -- Foreign key of article
    quantity FLOAT,
    unit_price DECIMAL(15, 2),
    discount DECIMAL(15, 2),
    account_id INT,
    total DECIMAL(15, 2),
    tab_articles_id INT, -- Foreign key of tab_articles
    comment TEXT,
    FOREIGN KEY (article_id) REFERENCES article(id),
    FOREIGN KEY (tab_articles_id) REFERENCES tab_articles(id) ON DELETE CASCADE
);

-- Create Invoice Sell Group Table
CREATE TABLE invoice_import_group (
    id INT PRIMARY KEY,
    label VARCHAR(255),
);

CREATE TABLE invoice_import_credit_group (
	id INT PRIMARY KEY,
	label VARCHAR(255)
);
CREATE TABLE order_to_supplier_group (
	id INT PRIMARY KEY,
	label VARCHAR(255)
);

-- Create Invoice Sell Table
CREATE TABLE invoice_import (
    id INT PRIMARY KEY,
    supplier_id INT, -- Foreign key of client
    n_invoice VARCHAR(255),
    n_order VARCHAR(255), 
    cdt_payment_id INT, -- Foreign key of payment_conditions
    invoice_date DATE,
    due_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    supplier_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    billing_address_id INT, -- Foreign key of address
    delivery_address_id INT, -- Foreign key of address
    invoice_import_group_id INT, -- Foreign key of invoice_sell_group
    payment_id INT, -- Foreign key of payment_sell
    FOREIGN KEY (supplier_id) REFERENCES supplier(id),
    FOREIGN KEY (cdt_payment_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id), -- Assuming tab_articles table exists
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (invoice_import_group_id) REFERENCES invoice_import_group(id),
    FOREIGN KEY (payment_id) REFERENCES payment_import(id)
);

-- Create Factures Avoirs
CREATE TABLE invoice_credit_import (
    id INT PRIMARY KEY,
    supplier_id INT, -- Foreign key of client
    n_invoice VARCHAR(255),
    n_reference VARCHAR(255), 
    invoice_date DATE,
    due_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    supplier_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    billing_address_id INT, -- Foreign key of address
    delivery_address_id INT, -- Foreign key of address
    invoice_import_credit_group_id INT,
    FOREIGN KEY (supplier_id) REFERENCES supplier(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id),
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (invoice_import_credit_group_id) REFERENCES invoice_import_credit_group(id),
);

-- Create Invoice Sell Table
CREATE TABLE order_to_supplier (
    id INT PRIMARY KEY,
    supplier_id INT, -- Foreign key of client
    n_reference VARCHAR(255),
    n_order VARCHAR(255), 
    cdt_payment_id INT, -- Foreign key of payment_conditions
    order_date DATE,
    estimated_expedition_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    supplier_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    delivery_address_id INT, -- Foreign key of address
	delivery_mode_id INT,
    order_to_supplier_group_id INT, -- Foreign key of invoice_sell_group
    payment_id INT, -- Foreign key of payment_sell
	state INT,
    FOREIGN KEY (supplier_id) REFERENCES supplier(id),
	FOREIGN KEY (delivery_mode_id) REFERENCES delivery_mode(id),
    FOREIGN KEY (cdt_payment_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id), -- Assuming tab_articles table exists
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (order_to_supplier_group_id) REFERENCES order_to_supplier_group(id),
    FOREIGN KEY (payment_id) REFERENCES payment_import(id)
);

-- Create Invoice Sell Group Table
CREATE TABLE invoice_sell_group (
    id INT PRIMARY KEY,
    import_invoice_id INT, -- Foreign key of invoice_import (assuming it exists)
    label VARCHAR(255),
    max_amount DECIMAL(15, 2),

	FOREIGN KEY (import_invoice_id) REFERENCES invoice_import(id)

);

CREATE TABLE invoice_sell_credit_group (
	id INT PRIMARY KEY,
	label VARCHAR(255)
);
CREATE TABLE custumer_order_group (
	id INT PRIMARY KEY,
	label VARCHAR(255)
);
-- Create Invoice Sell Table
CREATE TABLE invoice_sell (
    id INT PRIMARY KEY,
    client_id INT, -- Foreign key of client
    n_invoice VARCHAR(255),
    n_order VARCHAR(255), 
    cdt_payment_id INT, -- Foreign key of payment_conditions
    invoice_date DATE,
    due_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    client_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    billing_address_id INT, -- Foreign key of address
    delivery_address_id INT, -- Foreign key of address
    invoice_sell_group_id INT, -- Foreign key of invoice_sell_group
    payment_id INT, -- Foreign key of payment_sell
    FOREIGN KEY (client_id) REFERENCES client(id),
    FOREIGN KEY (cdt_payment_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id), -- Assuming tab_articles table exists
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (invoice_sell_group_id) REFERENCES invoice_sell_group(id),
    FOREIGN KEY (payment_id) REFERENCES payment_sell(id)
);

-- Create Factures Avoirs
CREATE TABLE invoice_credit_sell (
    id INT PRIMARY KEY,
    client_id INT, -- Foreign key of client
    n_invoice VARCHAR(255),
    n_reference VARCHAR(255), 
    invoice_date DATE,
    due_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    client_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    billing_address_id INT, -- Foreign key of address
    delivery_address_id INT, -- Foreign key of address
    invoice_sell_credit_group_id INT, -- Foreign key of invoice_sell_group
    FOREIGN KEY (client_id) REFERENCES client(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id), -- Assuming tab_articles table exists
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (billing_address_id) REFERENCES s_address(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (invoice_sell_credit_group_id) REFERENCES invoice_sell_credit_group(id),
);

-- Create Invoice Sell Table
CREATE TABLE custumer_order (
    id INT PRIMARY KEY,
    client_id INT, -- Foreign key of client
    n_reference VARCHAR(255),
    n_order VARCHAR(255), 
    cdt_payment_id INT, -- Foreign key of payment_conditions
    order_date DATE,
    estimated_expedition_date DATE,
    seller_id INT, -- Foreign key of seller
    person_to_contact_id INT, -- Foreign key of person_to_contact
    note TEXT,
    table_articles_id INT, -- Foreign key of tab_articles
    client_info VARCHAR(255),
    associated_docs_id INT, -- Foreign key of associated_docs
    delivery_address_id INT, -- Foreign key of address
	delivery_mode_id INT,
    custumer_order_group_id INT, -- Foreign key of invoice_sell_group
    payment_id INT, -- Foreign key of payment_sell
	state INT,
    FOREIGN KEY (client_id) REFERENCES client(id),
	FOREIGN KEY (delivery_mode_id) REFERENCES delivery_mode(id),
    FOREIGN KEY (cdt_payment_id) REFERENCES payment_conditions(id),
    FOREIGN KEY (seller_id) REFERENCES seller(id),
    FOREIGN KEY (person_to_contact_id) REFERENCES person_to_contact(id),
    FOREIGN KEY (table_articles_id) REFERENCES tab_articles(id), -- Assuming tab_articles table exists
    FOREIGN KEY (associated_docs_id) REFERENCES associated_docs(id),
    FOREIGN KEY (delivery_address_id) REFERENCES s_address(id),
    FOREIGN KEY (custumer_order_group_id) REFERENCES custumer_order_group(id),
    FOREIGN KEY (payment_id) REFERENCES payment_sell(id)
);

-- Create Packages Table
CREATE TABLE packages (
    id INT PRIMARY KEY,
    client_id INT, -- Foreign key of client
    custumer_order_id INT, -- Foreign key of customer_order
    packages_date DATE,
    n_bordero VARCHAR(255),
    intern_comments TEXT,
	state INT,
    FOREIGN KEY (client_id) REFERENCES client(id),
    FOREIGN KEY (custumer_order_id) REFERENCES custumer_order(id)
);

-- Create Package Row Table
CREATE TABLE package_row (
    id INT PRIMARY KEY,
    packages_id INT, -- Foreign key of packages
    article_id INT, -- Foreign key of article
    ordered_quantity FLOAT,
    packaged_quantity FLOAT,
    quantity_to_package FLOAT,
    FOREIGN KEY (packages_id) REFERENCES packages(id),
    FOREIGN KEY (article_id) REFERENCES article(id)
);

-- Create Discount Client Article Table
CREATE TABLE discount_client_article (
    id INT PRIMARY KEY,
    client_id INT, -- Foreign key of client
    article_id INT, -- Foreign key of article
    discount FLOAT,
    FOREIGN KEY (client_id) REFERENCES client(id),
    FOREIGN KEY (article_id) REFERENCES article(id)
);

-- Create Expense Type Table
CREATE TABLE expense_type (
    id INT PRIMARY KEY,
    label VARCHAR(255)
);

-- Create Department Table
CREATE TABLE department (
    id INT PRIMARY KEY,
    label VARCHAR(255),
    mission TEXT
);

-- Create Employees Table
CREATE TABLE employees (
    id INT PRIMARY KEY,
    title VARCHAR(10),
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    date_of_birth DATE,
    starting_date DATE,
    gender VARCHAR(1),
    department_id INT, -- Foreign key of department
    mission TEXT,
    salary DECIMAL(15, 2),
    salary_type VARCHAR(20), -- 'per_day' or 'per_week' or 'per_month'
    note TEXT,
    FOREIGN KEY (department_id) REFERENCES department(id)
);

-- Create Expenses Table
CREATE TABLE expenses (
    id INT PRIMARY KEY,
    label VARCHAR(255),
    amount DECIMAL(15, 2),
    date DATE,
    expense_type_id INT, -- Foreign key of expense_type
    FOREIGN KEY (expense_type_id) REFERENCES expense_type(id)
);

-- Create Employee Payment Table
CREATE TABLE employee_payment (
    id INT PRIMARY KEY,
    employee_id INT, -- Foreign key of employees
    payment_date DATE,
    amount DECIMAL(15, 2),
    rest DECIMAL(15, 2),
    FOREIGN KEY (employee_id) REFERENCES employees(id)
);

