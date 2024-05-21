-- create application database
CREATE DATABASE reservation_app;

-- create users table
CREATE TABLE users (
  user_id VARCHAR(255) PRIMARY KEY, 
  username VARCHAR (50) UNIQUE NOT NULL, 
  password VARCHAR (50) NOT NULL, 
  first_name VARCHAR (50) UNIQUE NOT NULL,
  last_name VARCHAR (50) UNIQUE NOT NULL,
  created_at TIMESTAMP NOT NULL
);

-- create reservation table
CREATE TABLE reservations (
   reservation_id VARCHAR(255) PRIMARY KEY,
   owner_first_name VARCHAR (50) NOT NULL,
   owner_last_name VARCHAR (50) NOT NULL,
   reservation_total_people INT,
   reservation_start_date TIMESTAMP NOT NULL,
   reservation_end_date TIMESTAMP NOT NULL,
   created_at TIMESTAMP NOT NULL,
   owner_id VARCHAR(255) NOT NULL,
   CONSTRAINT fk_user
      FOREIGN KEY(owner_id ) 
        REFERENCES users(user_id)
);