-- list all the gamblers
select * from gambler;

-- list all the rows in the host table
select * from host;

-- Show the name of each gambler and the casino names that hosts them
--
-- gambler_name is in the gambler table
-- casino_name is in the host table
-- when you need data from more than one table, you must find out what connecs them
-- the id of the gambler connects the gambler to the host table
--
-- Because the id the gambler has the same name in both tables
-- We qualify which table we want to take the id from
--
-- a qualifies name: table-name.column
--
-- When you need data from more than one table - its a JOIN (inner join)



 select gambler_name, casino_name	-- columns to see in result
 	from gambler, host 				-- table(s) that have the data you need
	where gambler.id = host.id		-- rows wanted in the result - rows that match between gambler and host tables	
	;