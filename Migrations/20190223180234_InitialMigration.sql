INSERT INTO userRoleTypes (name) VALUES('normal_user')
INSERT INTO userRoleTypes (name) VALUES('admin')
INSERT INTO productTypes (name) VALUES('coins')
INSERT INTO productTypes (name) VALUES('bot')
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_trial', 0, 1, 2)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1w', 10, 7, 2)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1m', 20, 30, 2)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1y', 100, 365, 2)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_100k', 100, 100, 1)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_1m', 1000, 1000, 1)
INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_10m', 10000, 10000, 1)
INSERT INTO users (modDate, username, email, pwd, typeValue) VALUES(CURDATE(), 'marcinSrarcin', 'testowy@email.com', 'r1bdp8Xh7wMm8Txmjvde/Tw1f3l/ThciQw29ewzSL9WEP62H3jgAexY2uI7t9E5G8oRV8MWxSQ4yIfRtHJMRSA==', 1)




DROP TABLE fifaCoins.transations;
DROP TABLE fifaCoins.products;
DROP TABLE fifaCoins.customers;
DROP TABLE fifaCoins.users;
DROP TABLE fifaCoins.productTypes;
DROP TABLE fifaCoins.userRoleTypes;
DROP TABLE fifaCoins.__EFMigrationsHistory;