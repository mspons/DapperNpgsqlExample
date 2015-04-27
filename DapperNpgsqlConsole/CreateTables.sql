/* Create tables */
CREATE TABLE styles (
	style_id serial PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
	description TEXT NOT NULL
);

CREATE TABLE beers (
	beer_id serial PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
	style_id integer REFERENCES styles(style_id),
	abv decimal(4,1) 
);
