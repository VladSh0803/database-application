USE PD2Movies
GO

--SQL SELECT 1
SELECT Users.Pseudonym AS UserNick, SUM(Films.Duration) AS TotalTime, Channels.Name AS ChannelName FROM History
JOIN Users ON Users.id = History.User_id
JOIN Films ON Films.id = History.Film_id
JOIN Channels ON Channels.id = Films.Channel_id
-- WHERE channels.id = 1
GROUP BY Users.id, Users.Pseudonym, Channels.Name
GO

--SQL SELECT 2
SELECT Users.Pseudonym AS Nickname, Channels.Name AS ChannelName, COUNT(History.Film_id) AS FilmViewed FROM Users
JOIN Channel_User ON Channel_User.User_id = Users.id
JOIN Channels ON Channels.id = Channel_User.Channel_id
JOIN Films ON Films.Channel_id = Channels.id
JOIN History ON History.Film_id = Films.id AND History.User_id = Users.id
GROUP BY Users.id, Users.Pseudonym, Channels.Name
HAVING COUNT(History.Film_id) < 3
GO

--SQL SELECT 3
SELECT sub2.Name AS GenreName, Films.Title AS FilmTitle FROM Films
JOIN
	(SELECT Genres.Name,
		(SELECT TOP 1 History.Film_id FROM History
		JOIN Film_Genre ON Film_Genre.Film_id = History.Film_id
		WHERE Film_Genre.Genre_id = genres.id
		GROUP BY History.Film_id
		ORDER BY COUNT(History.Film_id) DESC
		) AS MostPopularFilmId
	FROM Genres)
	sub2 ON sub2.MostPopularFilmId = Films.id
GO

--SQL SELECT 4
SELECT ROUND(Viewed / Published, 2) AS [Viewed / Published], Name FROM
	(SELECT CAST(Published.Count AS FLOAT) AS Published, COUNT(Films.id) AS Viewed, Channels.Name FROM History
	JOIN Films ON Films.id = History.Film_id
	JOIN Channels ON Channels.id = FIlms.Channel_id
	JOIN (SELECT COUNT(Films.id) AS Count, Channels.id AS id FROM Channels
		JOIN Films ON Films.Channel_id = Channels.id
		GROUP BY Channels.id) Published ON Published.id = Channels.id
	GROUP BY Channels.id, Published.Count, Channels.Name) Viewed_Published
ORDER BY [Viewed / Published] DESC
GO

--SQL SELECT 5
SELECT Title, Duration, Channels.Name AS ChannelName FROM Films
JOIN 
  (SELECT * FROM 
    (SELECT COUNT(User_id) AS SubscibersCount, Channel_id FROM Channel_User
    GROUP BY Channel_id) Y
  WHERE SubscibersCount = (SELECT TOP 1 COUNT(User_id) AS SubscibersMax FROM Channel_User
    GROUP BY Channel_id
    ORDER BY SubscibersMax DESC))
  Most_popular_channel
ON Films.Channel_id = Most_popular_channel.Channel_id
JOIN Channels ON Channels.id = Most_popular_channel.Channel_id
GO