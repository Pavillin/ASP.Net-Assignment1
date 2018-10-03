/*
    Project: Rocket League Stats
    Author: Dylan Sprague

	Note: Sample data is only accurate up to October 1st of Season 6
*/
/***************************************************/
-- Create table queries
DROP TABLE IF EXISTS dbo.players;
DROP TABLE IF EXISTS dbo.teams;
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
	"assists" INT NOT NULL DEFAULT '0',
	"saves" INT NOT NULL DEFAULT '0',
	"shots" INT NOT NULL DEFAULT '0',
	PRIMARY KEY ("playerid"),
	FOREIGN KEY ("teamid") REFERENCES teams(teamid)
);
/***************************************************/
--Starter Team Data
INSERT INTO dbo.teams (name, region, wins, losses) VALUES
('CLOUD9', 'NA', 5, 1),
('G2 ESPORTS', 'NA', 4, 1),
('NRG ESPORTS', 'NA', 4, 1),
('EVIL GENIUSES', 'NA', 4, 1),
('GHOST GAMING', 'NA', 1, 5),
('FLYQUEST', 'NA', 2, 4),
('ROGUE', 'NA', 1, 4),
('ALLEGIANCE', 'NA', 1, 5),
('TEAM DIGNITAS', 'EU', 5, 0),
('WE DEM GIRLZ', 'EU', 4, 1),
('FLIPSIDE TACTICS', 'EU', 3, 2),
('RENAULT SPORT TEAM VITALITY', 'EU', 2, 3),
('MOUSESPORTS', 'EU', 2, 4),
('PSG ESPORTS', 'EU', 2, 4),
('FNATIC', 'EU', 2, 4),
('COMPLEXITY GAMING', 'EU', 2, 4),
('CHIEFS ESPORTS CLUB', 'OCE', 5, 0),
('TAINTED MINDS', 'OCE', 5, 0),
('JUSTICE ESPORTS', 'OCE', 3, 3),
('SYF GAMING', 'OCE', 3, 3),
('LEGACY ESPORTS', 'OCE', 2, 3),
('ORDER', 'OCE', 2, 3),
('AVANT GAMING', 'OCE', 1, 5),
('GROUND ZERO GAMING', 'OCE', 1, 5)
;
/***************************************************/
--Starter Player Data
INSERT INTO dbo.players (teamid, name, goals, assists, saves, shots) VALUES
(1, 'Gimmick', 21, 19, 36, 59),
(1, 'SquishyMuffinz', 24, 14, 32, 76),
(1, 'Torment', 16, 16, 29, 45),

(2, 'Kronovi', 16, 9, 25, 70),
(2, 'Rizzo', 11, 12, 19, 46),
(2, 'JKnaps', 18, 14, 27, 66),

(3, 'JSTN', 22, 15, 30, 75),
(3, 'GarretG', 19, 11, 36, 63),
(3, 'Fireburner', 11, 19, 27, 60),

(4, 'Chicago', 14, 9, 28, 54),
(4, 'Klassux', 14, 10, 33, 62),
(4, 'CorruptedG', 14, 11, 30, 33),

(5, 'Memory', 17, 8, 51, 81),
(5, 'Lethamyr', 18, 9, 43, 77),
(5, 'Zanejackey', 8, 17, 36, 50),

(6, 'PrimeThunder', 20, 13, 31, 70),
(6, 'Wonder', 16, 21, 51, 71),
(6, 'ayyjayy', 19, 10, 36, 77),

(7, 'Jacob', 7, 8, 29, 45),
(7, 'Sizz', 15, 7, 32, 41),
(7, 'Joroelin', 8, 9, 39, 47),

(8, 'TyNotTyler', 7, 11, 34, 59),
(8, 'Allushin', 17, 11, 33, 47),
(8, 'Sea-bass', 17, 15, 42, 62),

(9, 'Kaydop', 22, 9, 26, 53),
(9, 'ViolentPanda', 14, 15, 27, 49),
(9, 'Turbopolsa', 15, 17, 31, 44),

(10, 'EyeIgnite', 14, 10, 28, 46),
(10, 'Metsanauris', 11, 11, 17, 41),
(10, 'Remkoe', 13, 8, 27, 46),

(11, 'Miztik', 5, 9, 26, 36),
(11, 'Kuxir97', 18, 8, 39, 57),
(11, 'Yukeo', 7, 9, 30, 39),

(12, 'paschy90', 18, 10, 21, 53),
(12, 'Fairy Peak!', 9, 19, 33, 45),
(12, 'Scrub Killa', 15, 7, 46, 63),

(13, 'Skyline', 15, 7, 37, 70),
(13, 'Alex161', 7, 11, 46, 52),
(13, 'Tigreee', 15, 7, 45, 54),

(14, 'chausette45', 9, 9, 34, 50),
(14, 'Ferra', 13, 8, 21, 49),
(14, 'fruity', 13, 13, 32, 62),

(15, 'MummiSnow', 10, 14, 25, 50),
(15, 'Maestro', 12, 7, 42, 63),
(15, 'Snaski', 11, 6, 34, 48),

(16, 'Mognus', 8, 10, 30, 54),
(16, 'al0t', 9, 6, 17, 56),
(16, 'gReazy', 13, 9, 42, 64),

(17, 'Torsos', 16, 13, 22, 48),
(17, 'Drippay', 25, 15, 27, 75),
(17, 'Kamii', 11, 15, 16, 35),

(18, 'Shadey', 15, 15, 26, 48),
(18, 'CJCJ', 25, 20, 20, 74),
(18, 'Express', 24, 21, 19, 66),

(19, 'SSteve', 13, 12, 30, 64),
(19, 'Whiss', 12, 6, 39, 53),
(19, 'Yeatzy', 18, 7, 38, 52),

(20, 'Requiem', 10, 14, 16, 40),
(20, 'Delusion', 16, 13, 49, 58),
(20, 'Decka', 25, 12, 39, 55),

(21, 'Cyrix', 11, 11, 19, 40),
(21, 'Siki_', 20, 13, 26, 55),
(21, 'Daze', 13, 11, 22, 49),

(22, 'Dumbo', 15, 16, 23, 57),
(22, 'Julz', 17, 16, 36, 59),
(22, 'ZeN', 18, 13, 18, 58),

(23, 'SnarfSnarf', 7, 17, 37, 48),
(23, 'Bango', 21, 9, 35, 59),
(23, 'Vive', 15, 5, 28, 45),

(24, 'Walcott', 10, 14, 39, 51),
(24, 'CJM', 10, 6, 18, 28),
(24, 'Lim', 19, 16, 46, 52),
(24, 'Ghost', 11, 2, 9, 25)
;
/***************************************************/