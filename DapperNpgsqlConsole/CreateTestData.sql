INSERT INTO styles (name, description)
	VALUES ('American Pale Ale', 'Hoppy deliciousness');
INSERT INTO styles (name, description)
	VALUES ('Beglian Golden Strong Ale', 'Golden deliciousness');

-- Not exactly best practice to rely on style_id being 1 and 2 here. Just a 
-- warning if you happen to run this multiple times.
INSERT INTO beers (name, style_id, abv)
	VALUES ('SweetWater 420', 1, 5.7);
INSERT INTO beers (name, style_id, abv)
	VALUES ('Sierra Nevada Pale Ale', 1, 5.6);

INSERT INTO beers (name, style_id, abv)
	VALUES ('Delirium Tremens', 2, 8.5);
