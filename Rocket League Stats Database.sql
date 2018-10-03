/*
    Project: Rocket League Stats
    Author: Dylan Sprague
*/
/***************************************************/
-- Create table queries
CREATE TABLE "teams" (
	"teamid" INT NOT NULL IDENTITY(1, 1),
	"name" VARCHAR(50) NOT NULL DEFAULT '0',
	"region" VARCHAR(3) NOT NULL DEFAULT '0',
	"wins" INT NOT NULL DEFAULT '0',
	"losses" INT NOT NULL DEFAULT '0',
	PRIMARY KEY ("teamid")
);

CREATE TABLE "players" (
	"playerid" INT NOT NULL IDENTITY(1, 1),
	"teamid" INT,
	"name" VARCHAR(50) NOT NULL DEFAULT '0',
	"goals" INT NOT NULL DEFAULT '0',
	"shots" INT NOT NULL DEFAULT '0',
	"assists" INT NOT NULL DEFAULT '0',
	PRIMARY KEY ("playerid"),
	FOREIGN KEY ("teamid") REFERENCES teams(teamid)
);
/***************************************************/
--Starter Team Data
INSERT INTO dbo.teams (name, region, wins, losses)
VALUES ('G2', 'NA', 4, 1);
/***************************************************/
--Starter Player Data
INSERT INTO dbo.players (teamid, name, goals, shots, assists)
VALUES (1, 'JKnaps', 20, 40, 14);
/***************************************************/