CREATE DATABASE Futbol;
GO
USE Futbol;
GO
USE [Futbol]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 14/02/2023 18:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[Codigo] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Pais] [varchar](50) NULL,
	[Goles] [int] NULL,
	[Puntos] [int] NULL,
	[PJ] [varchar](50) NULL,
	[PG] [int] NULL,
	[PE] [int] NULL,
	[PP] [int] NULL,
	[Estadio] [varchar](50) NULL,
	[Ciudad] [varchar](50) NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Futbolistas]    Script Date: 14/02/2023 18:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Futbolistas](
	[Codigo] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CodigoEquipo] [varchar](50) NULL,
	[Posicion] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Goles] [int] NULL,
	[TA] [int] NULL,
	[TR] [int] NULL,
	[Minutos] [int] NULL,
	[PrecioMercado] [varchar](50) NULL,
	[Dorsal] [int] NULL,
	[Peso] [int] NULL,
 CONSTRAINT [PK_Futbolistas] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#ATALA', N'Atalanta', N'Italia', 999, 7, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 1, 3, N'Estadio Atleti Azzurri d''Italia', N'Bérgamo')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#ATMDRD', N'Atlético de Madrid', N'España', 9, 10, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 4, 1, 2, N'Wanda Metropolitano', N'Madrid')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#BAYLEV', N'Bayer Leverkusen', N'Alemania', 4, 6, N'6(Fase Grupos)', 1, 0, 5, N'BayArena', N'Leverkusen')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#BAYMU', N'Bayern Múnich', N'Alemania', 27, 18, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 7, 0, 0, N'Allianz Arena', N'Munich')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#BENFI', N'Benfica', N'Portugal', 10, 7, N'6(Fase Grupos)', 2, 1, 3, N'Estadio da Luz', N'Lisboa')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#BORDOR', N'Borussia Dortmund', N'Alemania', 10, 10, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 5, 2, 0, N'Signal Iduna Park', N'Dortmund')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#BRUJAS', N'Brujas', N'Bélgica', 3, 3, N'6 (Fase Grupos)', 0, 3, 3, N'Jan-Breydel-Stadion', N'Brujas')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#CAOSNA', N'Club Atlético Osasuna', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'El Sadar', N'Pamplona')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#CHELSE', N'Chelsea', N'Inglaterra', 11, 11, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 2, 2, N'Stamford Brigde', N'Londres')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#DEPALV', N'Deportivo Alavés', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Mendizorroza', N'Vitoria')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#DEPOR', N'Deportivo de la Coruña', N'España', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#DINAM', N'Dinamo Zagreb', N'Croacia', 5, 10, N'6(Fase Grupos)', 1, 2, 3, N'Estadio Maksimir', N'Zagreb')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#ESTRE', N'Estrella Roja', N'Serbia', 3, 3, N'6(Fase Grupos)', 1, 0, 5, N'Estadio Estrella Roja', N'Belgrado')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#FCBLNA', N'FC Barcelona', N'España', 10, 14, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 4, 3, 0, N'Camp Nou', N'Barcelona')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#GENK', N'Genk', N'Bélgica', 5, 1, N'6(Fase Grupos)', 0, 1, 5, N'Luminus Arena', N'Genk')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#GETAFE', N'Getafe Club de Fútbol', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Coliseum Alfonso Perez', N'Getafe')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#GLTSRY', N'Galatasaray', N'Turquía', 2, 2, N'6(Fase Grupos)', 0, 2, 4, N'Ali Sami Yen Spor', N'Estambul')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#GRANDA', N'Granada Club de Fútbol', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Estadio Nuevo Los Cármenes', N'Granada')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#INTMIL', N'Inter Milán', N'Italia', 10, 7, N'6(Fase Grupos)', 2, 1, 3, N'Estadio Giuseppe Meazza', N'Milán')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#JUVE', N'Juventus', N'Italia', 12, 16, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 5, 1, 1, N'Juventus Stadium', N'Turín')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LEGNES', N'Club Deportivo Leganés', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Estadio Municipal Butarque', N'Leganés')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LEIPZ', N'Red Bull Leipzig', N'Alemania', 11, 11, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 4, 2, 1, N'Red Bull Arena', N'Leipzig')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LILLE', N'Lille', N'Francia', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Estadio Pierre-Mauroy', N'Lille')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LOKOM', N'Lokomotiv Moscú', N'Rusia', 5, 6, N'6(Fase Grupos)', 2, 0, 4, N'Estadio Lokomotiv', N'Moscú')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LVANTE', N'Levante Unión Deportiva', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Mestalla', N'Valencia')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LVPOOL', N'Liverpool', N'Inglaterra', 13, 13, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 4, 1, 2, N'Anfield', N'Liverpool')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#LYON', N'Olympique Lyon', N'Francia', 10, 8, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 2, 2, N'Parc Olympique Lyonnais', N'Lyon')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#MANCITY', N'Manchester City', N'Inglaterra', 18, 14, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 5, 2, 0, N'Etihad Stadium', N'Manchester')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#NAPOL', N'Nápoles', N'Italia', 12, 12, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 4, 0, N'San Paolo', N'Nápoles')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#OLYMP', N'Olympiakos', N'Grecia', 8, 4, N'6(Fase Grupos)', 1, 1, 4, N'Stadio Georgios Karaiskakis', N'El Pireo')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#PARIS', N'Paris Saint-Germain', N'Francia', 18, 16, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 5, 1, 1, N'Parc des Princes', N'París')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RBULL', N'Red Bull Salzburgo', N'Austria', 7, 16, N'6(Fase Grupos)', 2, 1, 3, N'Red Bull Arena', N'Salzburgo')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RCDESP', N'RCD Espanyol', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'RCDE Stadium', N'Barcelona')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RCDMLL', N'RCD Mallorca', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Son Moix', N'Mallorca')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RCELTA', N'Real Club Celta de Vigo', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Balaídos', N'Vigo')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RLBETIS', N'Real Betis Balompié', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Benito Villamarín', N'Sevilla')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RMDRID', N'Real Madrid', N'España', 15, 11, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 2, 2, N'Santiago Bernabeú', N'Madrid')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RSODAD', N'Real Sociedad de Fútbol', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Anoeta', N'San Sebastián')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#RVDLID', N'Real Valladolid CF', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'José Zorrilla', N'Valladolid')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#SHAK', N'Shaktar Donetsk', N'Ucrania', 6, 8, N'6(Fase Grupos)', 1, 3, 2, N'Estadio Metalist', N'Donetsk')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#SLAVIA', N'Slavia Praga', N'Chequia', 4, 2, N'6(Fase Grupos)', 0, 2, 4, N'Eden Arena', N'Praga')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#SVILLA', N'Sevilla Fútbol Club', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Sánchez Pizjuán', N'Sevilla')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#TOTNHM', N'Tottenham Hotspur', N'Inglaterra', 18, 10, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 1, 3, N'Tottenham H. Stadium', N'Londres')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#VLLARL', N'Villarreal Club de Fútbol', N'España', 4, 1, N'6(Fase Grupos)', 0, 1, 5, N'Estadio de la Cerámica', N'Castellón')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#VLNCIA', N'Valencia', N'España', 10, 11, N'6 (Fase Grupos) - 1 Partido Eliminatorias', 3, 2, 2, N'Mestalla', N'Valencia')
GO
INSERT [dbo].[Equipos] ([Codigo], [Nombre], [Pais], [Goles], [Puntos], [PJ], [PG], [PE], [PP], [Estadio], [Ciudad]) VALUES (N'#ZENIT', N'Zenit San Petersburgo', N'Rusia', 7, 7, N'6(Fase Grupos)', 2, 1, 3, N'Estadio Krestovski', N'San Petersburgo')
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0001', N'Unai Simón', N'#ATHBIL', N'Portero', 22, 0, 2, 0, 1800, N'10 Mill', 1, 88)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0002', N'Iago Herrerín', N'#ATHBIL', N'Portero', 31, 0, 0, 0, 270, N'3,5 Mill', 13, 88)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0003', N'Jokin Ezkieta', N'#ATHBIL', N'Portero', 23, 0, 0, 0, 0, N'500 mil', 31, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0004', N'Unai Núñez', N'#ATHBIL', N'Defensa', 22, 0, 3, 0, 765, N'15 Mill', 3, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0005', N'Iñigo Martínez', N'#ATHBIL', N'Defensa', 28, 0, 5, 0, 1800, N'32 Mill', 4, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0006', N'Yeray Álvarez', N'#ATHBIL', N'Defensa', 99, 0, 2, 0, 1890, N'30 Mill', 5, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0007', N'Lekue', N'#ATHBIL', N'Defensa', 26, 0, 0, 0, 308, N'2 Mill', 15, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0008', N'Yuri Berchiche', N'#ATHBIL', N'Defensa', 29, 2, 3, 0, 1791, N'20 Mill', 17, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0009', N'Óscar De Marcos', N'#ATHBIL', N'Defensa', 30, 0, 0, 0, 188, N'4 Mill', 18, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0010', N'Ander Capa', N'#ATHBIL', N'Defensa', 27, 2, 8, 0, 1886, N'7,5 Mill', 21, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0011', N'Balenziaga', N'#ATHBIL', N'Defensa', 31, 0, 1, 0, 270, N'2 Mill', 24, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0012', N'Mikel San José', N'#ATHBIL', N'Centrocampista', 30, 0, 2, 0, 355, N'6 Mill', 6, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0013', N'Beñat Etxebarría', N'#ATHBIL', N'Centrocampista', 32, 0, 0, 0, 388, N'3 Mill', 7, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0014', N'Unai López', N'#ATHBIL', N'Centrocampista', 23, 0, 5, 0, 1101, N'6 Mill', 8, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0015', N'Dani García', N'#ATHBIL', N'Centrocampista', 29, 0, 5, 0, 2008, N'6 Mill', 14, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0016', N'Vesga', N'#ATHBIL', N'Centrocampista', 26, 0, 1, 0, 375, N'3 Mill', 16, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0017', N'Raúl García', N'#ATHBIL', N'Centrocampista', 33, 6, 6, 0, 1764, N'7,5 Mill', 22, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0018', N'Sancet', N'#ATHBIL', N'Centrocampista', 19, 0, 1, 0, 263, N'2,5 Mill', 34, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0019', N'Iñaki Williams', N'#ATHBIL', N'Delantero', 25, 5, 2, 0, 1902, N'50 Mill', 9, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0020', N'Iker Muniaín', N'#ATHBIL', N'Delantero', 26, 4, 0, 1, 1401, N'17,5 Mill', 10, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0021', N'Córdoba', N'#ATHBIL', N'Delantero', 23, 0, 3, 0, 695, N'4 Mill', 11, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0022', N'Ibai Gómez', N'#ATHBIL', N'Delantero', 29, 0, 0, 0, 578, N'4 Mill', 19, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0023', N'Aritz Aduriz', N'#ATHBIL', N'Delantero', 39, 1, 2, 0, 161, N'1 Mill', 20, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0024', N'Kenan Kodro', N'#ATHBIL', N'Delantero', 26, 1, 0, 0, 329, N'1 Mill', 23, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AB0025', N'Villalibre', N'#ATHBIL', N'Delantero', 21, 1, 0, 0, 295, N'4 Mill', 25, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0001', N'Fernado Pacheco', N'#DEPALV', N'Portero', 27, 0, 0, 0, 1800, N'18 Mill', 1, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0002', N'Roberto', N'#DEPALV', N'Portero', 34, 0, 0, 0, 0, N'1 Mill', 13, 96)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0003', N'Aritz', N'#DEPALV', N'Portero', 21, 0, 0, 0, 0, N'500 mil', 31, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0004', N'Ruben Duarte', N'#DEPALV', N'Defensa', 24, 0, 8, 0, 1890, N'6 Mill', 3, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0005', N'Rodrigo Ely', N'#DEPALV', N'Defensa', 26, 0, 5, 0, 1316, N'2 Mill', 4, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0006', N'Victor Laguardia', N'#DEPALV', N'Defensa', 30, 1, 6, 1, 1529, N'9 Mill', 5, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0007', N'Magallán', N'#DEPALV', N'Defensa', 26, 1, 3, 0, 633, N'6 Mill', 6, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0008', N'Rafa Navarro', N'#DEPALV', N'Defensa', 25, 2, 0, 0, 0, N'850 mil', 12, 63)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0009', N'Adrián Marín', N'#DEPALV', N'Defensa', 23, 0, 0, 0, 338, N'800 mil', 17, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0010', N'Aguirregabiria', N'#DEPALV', N'Defensa', 24, 0, 0, 0, 1466, N'6 Mill', 21, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0011', N'Ximo Navarro', N'#DEPALV', N'Defensa', 30, 0, 6, 0, 1132, N'2,5 Mill', 23, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0012', N'Tachi', N'#DEPALV', N'Defensa', 22, 0, 0, 0, 10, N'1 Mill', 27, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0013', N'Tomás Pina', N'#DEPALV', N'Centrocampista', 32, 1, 3, 0, 899, N'2,5 Mill', 8, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0014', N'Victor Camarasa', N'#DEPALV', N'Centrocampista', 25, 0, 1, 0, 359, N'5 Mill', 10, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0015', N'Luís Rioja', N'#DEPALV', N'Centrocampista', 26, 0, 2, 0, 1129, N'2 Mill', 11, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0016', N'Fejsa', N'#DEPALV', N'Centrocampista', 31, 0, 0, 0, 103, N'3,5 Mill', 15, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0017', N'Edgar', N'#DEPALV', N'Centrocampista', 30, 0, 0, 0, 19, N'2 Mill', 16, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0018', N'Aleix Vidal', N'#DEPALV', N'Centrocampista', 30, 2, 5, 0, 1740, N'4,5 Mill', 18, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0019', N'Manu', N'#DEPALV', N'Centrocampista', 33, 0, 8, 1, 1556, N'2 Mill', 19, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0020', N'Pere Pons', N'#DEPALV', N'Centrocampista', 26, 1, 0, 0, 683, N'4 Mill', 20, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0021', N'Burke', N'#DEPALV', N'Centrocampista', 22, 1, 1, 0, 700, N'6 Mill', 24, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0022', N'Borja Sainz', N'#DEPALV', N'Centrocampista', 19, 0, 1, 0, 314, N'300 mil', 29, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0023', N'Ismael', N'#DEPALV', N'Centrocampista', 19, 0, 1, 0, 84, N'1 Mill', 35, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0024', N'Lucas Pérez', N'#DEPALV', N'Delantero', 31, 9, 2, 0, 1580, N'15 Mill', 7, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0025', N'Joselu Mato', N'#DEPALV', N'Delantero', 29, 9, 4, 0, 1731, N'5 Mill', 9, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AL0026', N'Burgui', N'#DEPALV', N'Delantero', 26, 0, 0, 0, 20, N'1,5 Mill', 14, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0000', N'Antonio Adán', N'#ATMDRD', N'Portero', 33, 0, 0, 0, 24, N'1 Mill', 1, 93)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0001', N'Jan Oblak', N'#ATMDRD', N'Portero', 27, 0, 0, 0, 2046, N'100 Mill', 13, 87)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0002', N'Josema Giménez', N'#ATMDRD', N'Defensa', 25, 0, 0, 0, 990, N'70 Mill', 2, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0003', N'Santiago Arias', N'#ATMDRD', N'Defensa', 28, 0, 0, 0, 485, N'15 Mill', 4, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0004', N'Renan Lodi', N'#ATMDRD', N'Defensa', 21, 1, 1, 1, 1439, N'25 Mill', 12, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0005', N'Stefan Saviç', N'#ATMDRD', N'Defensa', 29, 0, 3, 0, 900, N'32 Mill', 15, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0006', N'Felipe', N'#ATMDRD', N'Defensa', 30, 1, 5, 0, 1441, N'25 Mill', 18, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0007', N'Mario Hermoso', N'#ATMDRD', N'Defensa', 24, 0, 2, 0, 960, N'25 Mill', 22, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0008', N'Kieran Trippier', N'#ATMDRD', N'Defensa', 29, 0, 1, 0, 1315, N'35 Mill', 23, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0009', N'Sime Vrsaljko', N'#ATMDRD', N'Defensa', 28, 0, 2, 0, 268, N'15 Mill', 24, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0010', N'Thomas Partey', N'#ATMDRD', N'Centrocampista', 26, 1, 9, 0, 1570, N'50 Mill', 5, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0011', N'Koke Resurreción', N'#ATMDRD', N'Centrocampista', 28, 1, 3, 0, 1980, N'60 Mill', 6, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0012', N'Saúl Ñíguez', N'#ATMDRD', N'Centrocampista', 25, 2, 6, 0, 1980, N'90 Mill', 8, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0013', N'Thomas Lemar', N'#ATMDRD', N'Centrocampista', 24, 0, 1, 0, 808, N'30 Mill', 11, 63)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0014', N'Marcos Llorente', N'#ATMDRD', N'Centrocampista', 25, 0, 4, 0, 536, N'20 Mill', 16, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0015', N'Hector Herrera', N'#ATMDRD', N'Centrocampista', 29, 0, 0, 0, 833, N'20 Mill', 14, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0016', N'Vitolo', N'#ATMDRD', N'Delantero', 30, 2, 3, 0, 857, N'18 Mill', 20, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0017', N'Yannick F. Carrasco', N'#ATMDRD', N'Delantero', 26, 0, 0, 0, 50, N'28 Mill', 21, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0018', N'Joao Félix', N'#ATMDRD', N'Delantero', 20, 2, 3, 0, 1262, N'100 Mill', 7, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0019', N'Álvaro Morata', N'#ATMDRD', N'Delantero', 27, 7, 3, 1, 1386, N'50 Mill', 9, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0020', N'Ángel Correa', N'#ATMDRD', N'Delantero', 24, 4, 5, 0, 1154, N'35 Mill', 10, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0021', N'Ivan Saponjiç', N'#ATMDRD', N'Delantero', 22, 0, 0, 0, 2, N'1,5 Mill', 17, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'AM0022', N'Diego Costa', N'#ATMDRD', N'Delantero', 31, 2, 2, 0, 757, N'18 Mill', 19, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'CHE001', N'DIDIER DROGBA', N'System.Data.DataRowView', N'DELANTERO', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0001', N'Dmitroviç', N'#SDEIBR', N'Portero', 28, 0, 3, 0, 2070, N'12 Mill', 1, 94)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0002', N'Yoel', N'#SDEIBR', N'Portero', 31, 0, 0, 0, 0, N'1,5 Mill', 13, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0003', N'Esteban Burgos', N'#SDEIBR', N'Defensa', 28, 1, 2, 0, 429, N'900 mil', 2, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0004', N'Bigas', N'#SDEIBR', N'Defensa', 29, 0, 1, 0, 776, N'2 Mill', 3, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0005', N'Ramis', N'#SDEIBR', N'Defensa', 35, 1, 1, 0, 458, N'800 mil', 4, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0006', N'Paulo Oliveira', N'#SDEIBR', N'Defensa', 28, 1, 4, 1, 1410, N'6 Mill', 12, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0007', N'Cote', N'#SDEIBR', N'Defensa', 30, 1, 1, 0, 1476, N'4 Mill', 15, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0008', N'Rober Correa', N'#SDEIBR', N'Defensa', 27, 0, 0, 0, 257, N'600 mil', 20, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0009', N'Arbilla', N'#SDEIBR', N'Defensa', 32, 1, 5, 0, 1369, N'2 Mill', 23, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0010', N'Álvaro Tejero', N'#SDEIBR', N'Defensa', 23, 0, 3, 0, 1103, N'3 Mill', 24, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0011', N'Gonzalo Escalante', N'#SDEIBR', N'Centrocampista', 26, 0, 3, 0, 1200, N'4 Mill', 5, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0012', N'Sergio Álvarez', N'#SDEIBR', N'Centrocampista', 28, 0, 4, 0, 638, N'2 Mill', 6, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0013', N'Pape Diop', N'#SDEIBR', N'Centrocampista', 33, 1, 5, 0, 1413, N'1,5 Mill', 8, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0014', N'Edu Expósito', N'#SDEIBR', N'Centrocampista', 23, 2, 3, 1, 1376, N'4 Mill', 10, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0015', N'Fabián Orellana', N'#SDEIBR', N'Centrocampista', 34, 6, 6, 1, 1720, N'2 Mill', 14, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0016', N'De Blasis', N'#SDEIBR', N'Centrocampista', 32, 0, 0, 0, 966, N'1,8 Mill', 16, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0017', N'Cristóforo', N'#SDEIBR', N'Centrocampista', 26, 0, 0, 0, 143, N'1,5 Mill', 18, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0018', N'Pedro León', N'#SDEIBR', N'Centrocampista', 33, 1, 3, 0, 1319, N'1,8 Mill', 21, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0019', N'Takashi Inui', N'#SDEIBR', N'Centrocampista', 31, 1, 2, 0, 1332, N'3 Mill', 22, 63)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0020', N'Quique González', N'#SDEIBR', N'Delantero', 29, 0, 0, 0, 342, N'1 Mill', 7, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0021', N'Sergi Enrich', N'#SDEIBR', N'Delantero', 30, 1, 2, 0, 1205, N'3 Mill', 9, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0022', N'Kike García', N'#SDEIBR', N'Delantero', 31, 3, 2, 0, 996, N'3 Mill', 17, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'EB0023', N'Charles Días', N'#SDEIBR', N'Delantero', 35, 2, 5, 0, 744, N'1,5 Mill', 19, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0001', N'Ter Stegen', N'#FCBLNA', N'Portero', 28, 0, 0, 0, 1980, N'90 Mill', 1, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0002', N'Neto Murara', N'#FCBLNA', N'Portero', 30, 0, 0, 0, 90, N'18 Mill', 13, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0003', N'Nelson Semedo', N'#FCBLNA', N'Defensa', 26, 0, 1, 0, 1114, N'40 Mill', 2, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0004', N'Gerard Piqué', N'#FCBLNA', N'Defensa', 33, 1, 10, 0, 1883, N'25 Mill', 3, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0005', N'Clément Lenglet', N'#FCBLNA', N'Defensa', 24, 2, 4, 2, 1551, N'60 Mill', 15, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0006', N'Jordi Alba', N'#FCBLNA', N'Defensa', 30, 1, 3, 0, 1175, N'50 Mill', 18, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0007', N'Sergi Roberto', N'#FCBLNA', N'Defensa', 28, 0, 7, 0, 1650, N'50 Mill', 20, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0008', N'Samuel Umtiti', N'#FCBLNA', N'Defensa', 26, 0, 3, 0, 637, N'40 Mill', 23, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0009', N'Junior Firpo', N'#FCBLNA', N'Defensa', 23, 1, 2, 0, 651, N'25 Mill', 24, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0010', N'Riqui Puig', N'#FCBLNA', N'Centrocampista', 20, 0, 0, 0, 22, N'10 Mill', 28, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0011', N'Ivan Rakitic', N'#FCBLNA', N'Centrocampista', 31, 0, 2, 0, 774, N'25 Mill', 4, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0012', N'Sergio Busquets', N'#FCBLNA', N'Centrocampista', 31, 2, 7, 0, 1471, N'35 Mill', 5, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0013', N'Arthur Melo', N'#FCBLNA', N'Centrocampista', 23, 2, 1, 0, 761, N'70 Mill', 8, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0014', N'Frenkie de Jong', N'#FCBLNA', N'Centrocampista', 22, 2, 1, 1, 1693, N'90 Mill', 21, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0015', N'Eric García', N'#FCBLNA', N'Defensa', 23, 0, 5, 1, 300, N'2 Mill', 22, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0016', N'Luis Suárez', N'#FCBLNA', N'Delantero', 33, 11, 4, 0, 1278, N'40 Mill', 9, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0017', N'Leo Messi', N'#FCBLNA', N'Delantero', 32, 14, 1, 0, 1530, N'500 Mill', 10, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0018', N'Ousmane Dembele', N'#FCBLNA', N'Delantero', 22, 1, 1, 0, 358, N'75 Mill', 11, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0019', N'Antoine Griezmann', N'#FCBLNA', N'Delantero', 28, 7, 2, 0, 1810, N'120 Mill', 17, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'FC0020', N'Ansu Fati', N'#FCBLNA', N'Delantero', 17, 4, 1, 0, 584, N'40 Mill', 31, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0001', N'Leandro Chichizola', N'#GETAFE', N'Portero', 30, 0, 0, 0, 0, N'1,5 Mill', 1, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0002', N'David Soria', N'#GETAFE', N'Portero', 27, 0, 1, 0, 2070, N'18 Mill', 13, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0003', N'Mathias Olivera', N'#GETAFE', N'Defensa', 23, 0, 1, 1, 704, N'2 Mill', 17, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0004', N'Nyom', N'#GETAFE', N'Defensa', 32, 2, 9, 0, 1550, N'3,5 Mill', 12, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0005', N'Damián Suárez', N'#GETAFE', N'Defensa', 32, 1, 10, 0, 1662, N'3,5 Mill', 22, 61)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0006', N'Victorino Antunes', N'#GETAFE', N'Defensa', 33, 0, 0, 0, 55, N'2 Mill', 3, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0007', N'Djene', N'#GETAFE', N'Defensa', 29, 0, 2, 0, 1890, N'25 Mill', 2, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0008', N'Etxeita', N'#GETAFE', N'Defensa', 33, 0, 4, 0, 585, N'1,8 Mill', 16, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0009', N'Chema Rodríguez', N'#GETAFE', N'Defensa', 28, 0, 0, 0, 0, N'1,5 Mill', 6, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0010', N'Erik Cabaco', N'#GETAFE', N'Defensa', 25, 0, 4, 0, 0, N'5 Mill', 4, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0011', N'Etebo ', N'#GETAFE', N'Centrocampista', 24, 0, 0, 0, 131, N'5 Mill', 5, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0012', N'David Timor', N'#GETAFE', N'Centrocampista', 30, 2, 2, 0, 313, N'2 Mill', 24, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0013', N'Jason Remeseiro', N'#GETAFE', N'Centrocampista', 25, 1, 5, 0, 877, N'6 Mill', 23, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0014', N'Kenedy', N'#GETAFE', N'Centrocampista', 24, 1, 1, 0, 412, N'12 Mill', 25, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0015', N'Fayçal Fajr', N'#GETAFE', N'Centrocampista', 31, 0, 2, 0, 389, N'4 Mill', 21, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0016', N'Arambarri', N'#GETAFE', N'Centrocampista', 24, 1, 7, 0, 1980, N'20 Mill', 18, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0017', N'Portillo', N'#GETAFE', N'Centrocampista', 29, 0, 2, 0, 335, N'3,5 Mill', 8, 60)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0018', N'Cucurella', N'#GETAFE', N'Centrocampista', 21, 1, 4, 0, 2140, N'15 Mill', 15, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0019', N'Maksimovic', N'#GETAFE', N'Centrocampista', 25, 1, 3, 0, 1844, N'20 Mill', 20, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0020', N'Jaime Mata', N'#GETAFE', N'Delantero', 31, 8, 8, 0, 1774, N'10 Mill', 7, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0021', N'Ángel', N'#GETAFE', N'Delantero', 32, 10, 3, 0, 950, N'7,5 Mill', 9, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0022', N'Amath', N'#GETAFE', N'Delantero', 23, 0, 0, 0, 0, N'3 Mill', 11, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0023', N'Jorge Molina', N'#GETAFE', N'Delantero', 37, 5, 3, 1, 1280, N'2 Mill', 19, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GE0024', N'Deyverson', N'#GETAFE', N'Delantero', 28, 0, 1, 0, 79, N'3,5 Mill', 14, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0001', N'Rui Silva', N'#GRANDA', N'Portero', 26, 0, 1, 0, 1890, N'5 Mill', 1, 91)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0002', N'Aarón', N'#GRANDA', N'Portero', 25, 0, 0, 0, 0, N'300 mil', 13, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0003', N'Foulquier', N'#GRANDA', N'Defensa', 27, 0, 0, 0, 166, N'2,5 Mill', 2, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0004', N'Vallejo', N'#GRANDA', N'Defensa', 23, 0, 0, 0, 5, N'10 Mill', 20, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0005', N'Álex M.', N'#GRANDA', N'Defensa', 30, 0, 1, 0, 14, N'900 mil', 3, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0006', N'Martínez', N'#GRANDA', N'Defensa', 27, 0, 0, 0, 780, N'1,5 Mill', 5, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0007', N'Germán', N'#GRANDA', N'Defensa', 34, 2, 6, 1, 1231, N'500 mil', 6, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0008', N'Ismail', N'#GRANDA', N'Defensa', 31, 0, 0, 0, 45, N'400 mil', 11, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0009', N'Neva', N'#GRANDA', N'Defensa', 24, 0, 1, 0, 1091, N'1 Mill', 15, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0010', N'Víctor Díaz', N'#GRANDA', N'Defensa', 32, 0, 2, 0, 1800, N'1,5 Mill', 16, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0011', N'Neyder Lozano', N'#GRANDA', N'Defensa', 26, 0, 0, 0, 0, N'600 mil', 18, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0012', N'Domingos Duarte', N'#GRANDA', N'Defensa', 25, 2, 4, 0, 1840, N'5 Mill', 22, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0013', N'Gonalons', N'#GRANDA', N'Centrocampista', 31, 0, 5, 0, 1101, N'3,5 Mill', 4, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0014', N'Yan Eteki', N'#GRANDA', N'Centrocampista', 23, 0, 3, 0, 658, N'1 Mill', 8, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0015', N'Azeez', N'#GRANDA', N'Centrocampista', 28, 2, 3, 0, 728, N'1 Mill', 12, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0016', N'Montoro', N'#GRANDA', N'Centrocampista', 32, 1, 5, 0, 883, N'1,5 Mill', 19, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0017', N'Yangel Herrera', N'#GRANDA', N'Centrocampista', 22, 2, 6, 0, 1162, N'3 Mill', 21, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0018', N'Gil Dias', N'#GRANDA', N'Delantero', 23, 0, 0, 0, 84, N'4 Mill', 17, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0019', N'Vadillo', N'#GRANDA', N'Delantero', 26, 3, 0, 0, 1029, N'3 Mill', 7, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0020', N'Soldado', N'#GRANDA', N'Delantero', 35, 2, 8, 0, 1339, N'1 Mill', 9, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0021', N'Antonio Puertas', N'#GRANDA', N'Delantero', 28, 5, 4, 0, 1577, N'3 Mill', 10, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0022', N'Fede Vico', N'#GRANDA', N'Delantero', 26, 1, 0, 0, 259, N'1,5 Mill', 14, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0023', N'Darwin Machís', N'#GRANDA', N'Delantero', 27, 3, 3, 0, 1181, N'3 Mill', 23, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'GR0024', N'Carlos Fernández', N'#GRANDA', N'Delantero', 24, 5, 5, 0, 1051, N'3 Mill', 24, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0001', N'Iván Cuéllar', N'#LEGNES', N'Portero', 36, 0, 1, 1, 1259, N'800 mil', 1, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0002', N'Juan Soriano', N'#LEGNES', N'Portero', 23, 0, 2, 0, 900, N'2 Mill', 13, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0003', N'Marc Navarro', N'#LEGNES', N'Defensa', 25, 0, 1, 0, 219, N'1,5 Mill', 2, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0004', N'Unai Bustinza', N'#LEGNES', N'Defensa', 28, 0, 3, 0, 1791, N'4 Mill', 3, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0005', N'Omeruo', N'#LEGNES', N'Defensa', 27, 1, 5, 0, 1399, N'3 Mill', 4, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0006', N'Jonathan Silva', N'#LEGNES', N'Defensa', 26, 0, 9, 0, 1980, N'3,5 Mill', 5, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0007', N'Awaziem', N'#LEGNES', N'Defensa', 23, 0, 5, 0, 1234, N'2,5 Mill', 12, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0008', N'Tarín', N'#LEGNES', N'Defensa', 23, 0, 1, 0, 356, N'1,5 Mill', 15, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0009', N'Rosales', N'#LEGNES', N'Defensa', 31, 0, 5, 0, 1126, N'2 Mill', 16, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0010', N'Siovas', N'#LEGNES', N'Defensa', 31, 0, 0, 0, 1134, N'4 Mill', 22, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0011', N'Kevin Rodrigues', N'#LEGNES', N'Defensa', 25, 1, 0, 1, 1095, N'2,5 Mill', 24, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0012', N'Roque Mesa ', N'#LEGNES', N'Centrocampista', 30, 1, 8, 0, 1507, N'7 Mill', 6, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0013', N'Recio', N'#LEGNES', N'Centrocampista', 29, 0, 9, 0, 1203, N'3 Mill', 8, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0014', N'Szymanowski', N'#LEGNES', N'Centrocampista', 31, 0, 0, 0, 0, N'1 Mill', 11, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0015', N'Eraso', N'#LEGNES', N'Centrocampista', 29, 0, 2, 0, 504, N'1,5 Mill', 17, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0016', N'Aitor Ruibal', N'#LEGNES', N'Centrocampista', 23, 0, 0, 0, 399, N'1,2 Mill', 19, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0017', N'Rubén Pérez', N'#LEGNES', N'Centrocampista', 30, 0, 6, 0, 1299, N'7,5 Mill', 21, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0018', N'Amadou', N'#LEGNES', N'Centrocampista', 26, 0, 0, 0, 0, N'7 Mill', 23, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0019', N'Bryan Gil', N'#LEGNES', N'Centrocampista', 19, 0, 3, 0, 98, N'10 Mill', 26, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0020', N'Óscar', N'#LEGNES', N'Centrocampista', 21, 5, 3, 0, 1450, N'12 Mill', 27, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0021', N'Braithwaite', N'#FCBLNA', N'Delantero', 28, 6, 3, 0, 18, N'10 Mill', 7, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0022', N'Guerrero', N'#LEGNES', N'Delantero', 29, 0, 0, 0, 59, N'2 Mill', 9, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0023', N'Guido Carrillo', N'#LEGNES', N'Delantero', 28, 0, 1, 1, 730, N'6 Mill', 18, 87)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LE0024', N'Assalé', N'#LEGNES', N'Delantero', 26, 0, 0, 0, 39, N'7,5 Mill', 20, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0001', N'Koke Vegas', N'#LVANTE', N'Portero', 24, 0, 2, 0, 2160, N'7,5 Mill', 13, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0002', N'Aitor Fernández', N'#LVANTE', N'Portero', 28, 0, 0, 0, 0, N'700 mil', 1, 88)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0003', N'Rubén Vezo', N'#LVANTE', N'Defensa', 25, 0, 4, 0, 1620, N'6 Mill', 14, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0004', N'Sergio Postigo', N'#LVANTE', N'Defensa', 31, 1, 4, 0, 1572, N'2 Mill', 15, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0005', N'Rober Pier', N'#LVANTE', N'Defensa', 25, 0, 0, 0, 0, N'1,5 Mill', 4, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0006', N'Bruno González', N'#LVANTE', N'Defensa', 29, 0, 1, 0, 0, N'1,5 Mill', 18, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0007', N'Óscar Duarte', N'#LVANTE', N'Defensa', 30, 0, 0, 0, 305, N'900 mil', 6, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0008', N'Carles Clerc', N'#LVANTE', N'Defensa', 27, 0, 4, 0, 1169, N'2,5 Mill', 19, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0009', N'Toño', N'#LVANTE', N'Defensa', 30, 0, 0, 0, 991, N'900 mil', 3, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0010', N'Jorge Miramón', N'#LVANTE', N'Defensa', 30, 0, 2, 0, 1705, N'3,5 Mill', 20, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0011', N'Coke Andújar', N'#LVANTE', N'Defensa', 32, 0, 2, 0, 549, N'1,5 Mill', 23, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0012', N'Iván López', N'#LVANTE', N'Defensa', 26, 0, 0, 0, 0, N'300 mil', 2, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0013', N'Nemanja Radoja', N'#LVANTE', N'Centrocampista', 27, 1, 2, 0, 1364, N'4 Mill', 5, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0014', N'Nikola Vukceviç', N'#LVANTE', N'Centrocampista', 28, 0, 7, 0, 847, N'3 Mill', 17, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0015', N'Enis Bardhi', N'#LVANTE', N'Centrocampista', 24, 2, 4, 0, 1175, N'15 Mill', 10, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0016', N'José Campaña', N'#LVANTE', N'Centrocampista', 26, 2, 3, 1, 2037, N'15 Mill', 24, 55)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0017', N'Gonzalo Melero', N'#LVANTE', N'Centrocampista', 26, 1, 3, 0, 758, N'4 Mill', 22, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0018', N'Rubén Rochina', N'#LVANTE', N'Centrocampista', 28, 3, 4, 0, 1261, N'4 Mill', 16, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0019', N'Hernáni', N'#LVANTE', N'Delantero', 28, 2, 2, 1, 420, N'2,5 Mill', 8, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0020', N'Roger Martí', N'#LVANTE', N'Delantero', 29, 10, 3, 0, 1421, N'10 Mill', 9, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0021', N'Jose Luís Morales', N'#LVANTE', N'Delantero', 32, 1, 1, 0, 1703, N'8 Mill', 11, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0022', N'Borja Mayoral', N'#LVANTE', N'Delantero', 22, 5, 2, 0, 1330, N'4 Mill', 21, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'LV0023', N'Sergio León', N'#LVANTE', N'Delantero', 31, 1, 2, 0, 430, N'3 Mill', 7, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0001', N'Manolo Reina', N'#RCDMLL', N'Portero', 34, 0, 2, 0, 1800, N'300 mil', 1, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0002', N'Fabricio', N'#RCDMLL', N'Portero', 34, 0, 1, 0, 90, N'1,5 Mill', 13, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0003', N'Joan Sastre', N'#RCDMLL', N'Defensa', 22, 0, 4, 0, 1211, N'2 Mill', 2, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0004', N'Lumor', N'#RCDMLL', N'Defensa', 23, 0, 2, 1, 1219, N'1,5 Mill', 3, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0005', N'Xisco Campos', N'#RCDMLL', N'Defensa', 37, 0, 1, 0, 299, N'100 mil', 5, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0006', N'Fran Gámez', N'#RCDMLL', N'Defensa', 28, 0, 1, 0, 1170, N'800 mil', 15, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0007', N'Abdul Rahman', N'#RCDMLL', N'Defensa', 25, 0, 1, 0, 109, N'4,5 Mill', 18, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0008', N'Sedlar', N'#RCDMLL', N'Defensa', 28, 0, 1, 0, 152, N'800 mil', 20, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0009', N'Raíllo', N'#RCDMLL', N'Defensa', 28, 1, 3, 1, 1497, N'2,5 Mill', 21, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0010', N'Valjent', N'#RCDMLL', N'Defensa', 24, 0, 4, 0, 1890, N'2,5 Mill', 24, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0011', N'Josep Señe', N'#RCDMLL', N'Centrocampista', 28, 0, 0, 0, 134, N'300 mil', 4, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0012', N'Pedraza', N'#RCDMLL', N'Centrocampista', 33, 0, 0, 0, 74, N'300 mil', 6, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0013', N'Salva Sevilla', N'#RCDMLL', N'Centrocampista', 35, 3, 6, 0, 1466, N'200 mil', 8, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0014', N'Lago Junior', N'#RCDMLL', N'Centrocampista', 29, 4, 2, 0, 1465, N'4 Mill', 11, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0015', N'Baba', N'#RCDMLL', N'Centrocampista', 24, 0, 5, 0, 1585, N'2,5 Mill', 12, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0016', N'Dani Rodríguez', N'#RCDMLL', N'Centrocampista', 31, 4, 2, 0, 1693, N'1,5 Mill', 14, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0017', N'Salibur', N'#RCDMLL', N'Centrocampista', 29, 0, 0, 0, 52, N'1,5 Mill', 16, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0018', N'Aleix Febas', N'#RCDMLL', N'Centrocampista', 23, 0, 3, 0, 1270, N'3,5 Mill', 23, 61)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0019', N'Takefusa Kubo', N'#RCDMLL', N'Centrocampista', 18, 1, 2, 0, 1075, N'15 Mill', 26, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0020', N'Abdón', N'#RCDMLL', N'Delantero', 27, 0, 1, 0, 139, N'800 mil', 9, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0021', N'Trajkovski', N'#RCDMLL', N'Delantero', 27, 0, 0, 0, 147, N'1,5 Mill', 17, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0022', N'Chavarría', N'#RCDMLL', N'Delantero', 32, 0, 0, 0, 66, N'1,5 Mill', 19, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'ML0023', N'Ante Budimir', N'#RCDMLL', N'Delantero', 28, 8, 5, 0, 1626, N'4 Mill', 22, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0001', N'Sergio Herrera', N'#CAOSNA', N'Portero', 26, 0, 2, 0, 881, N'1,5 Mill', 1, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0002', N'Rubén', N'#CAOSNA', N'Portero', 35, 0, 0, 0, 1099, N'700 mil', 13, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0003', N'Nacho Vidal', N'#CAOSNA', N'Defensa', 25, 0, 4, 0, 1466, N'3 Mill', 2, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0004', N'Raúl Navas', N'#CAOSNA', N'Defensa', 31, 0, 1, 0, 395, N'1,5 Mill', 3, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0005', N'Unai García', N'#CAOSNA', N'Defensa', 27, 1, 0, 0, 198, N'1 Mill', 4, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0006', N'David García', N'#CAOSNA', N'Defensa', 26, 0, 4, 1, 1712, N'3 Mill', 5, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0007', N'Oier Sanjurjo', N'#CAOSNA', N'Defensa', 33, 2, 7, 0, 1391, N'1,2 Mill', 6, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0008', N'Roncaglia', N'#CAOSNA', N'Defensa', 33, 1, 2, 2, 844, N'1,8 Mill', 12, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0009', N'Toni Lato', N'#CAOSNA', N'Defensa', 22, 0, 0, 0, 0, N'2 Mill', 15, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0010', N'Aridane', N'#CAOSNA', N'Defensa', 30, 2, 5, 0, 1620, N'1,5 Mill', 23, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0011', N'Endika', N'#CAOSNA', N'Defensa', 23, 0, 0, 0, 0, N'200 mil', 29, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0012', N'Estupiñán', N'#CAOSNA', N'Defensa', 22, 1, 6, 0, 2067, N'7,5 Mill', 30, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0013', N'Fran Mérida', N'#CAOSNA', N'Centrocampista', 29, 0, 5, 1, 897, N'1,5 Mill', 8, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0014', N'Roberto Torres', N'#CAOSNA', N'Centrocampista', 30, 4, 1, 0, 1894, N'3,5 Mill', 10, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0015', N'Rubén García', N'#CAOSNA', N'Centrocampista', 26, 6, 4, 0, 1693, N'5 Mill', 14, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0016', N'Robert Ibáñez', N'#CAOSNA', N'Centrocampista', 26, 1, 2, 0, 472, N'1 Mill', 17, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0017', N'Kike Barja', N'#CAOSNA', N'Centrocampista', 22, 0, 0, 0, 0, N'1 Mill', 19, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0018', N'Darko', N'#CAOSNA', N'Centrocampista', 28, 0, 6, 0, 1409, N'2 Mill', 20, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0019', N'Íñigo Pérez', N'#CAOSNA', N'Centrocampista', 32, 1, 0, 0, 427, N'600 mil', 21, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0020', N'Moncayola', N'#CAOSNA', N'Centrocampista', 21, 1, 4, 0, 972, N'1,5 Mill', 27, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0021', N'Marc Cardona', N'#CAOSNA', N'Delantero', 24, 1, 1, 0, 514, N'1,5 Mill', 7, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0022', N'Chimy Ávila', N'#CAOSNA', N'Delantero', 26, 9, 6, 0, 1593, N'15 Mill', 9, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0023', N'Enric Gallego', N'#CAOSNA', N'Delantero', 33, 0, 1, 0, 305, N'1,5 Mill', 11, 87)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0024', N'Jose Arnáiz', N'#CAOSNA', N'Delantero', 24, 0, 2, 0, 413, N'2,5 Mill', 16, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0025', N'Juan Villar', N'#CAOSNA', N'Delantero', 31, 1, 1, 0, 234, N'800 mil', 18, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'OS0026', N'Adrián ', N'#CAOSNA', N'Delantero', 32, 0, 0, 0, 867, N'1,8 Mill', 22, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0001', N'Joel Robles', N'#RLBETIS', N'Portero', 29, 0, 3, 1, 2070, N'7,5 Mill', 1, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0002', N'Dani ', N'#RLBETIS', N'Portero', 21, 0, 0, 0, 350, N'3 Mill', 13, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0003', N'Zou Feddal', N'#RLBETIS', N'Defensa', 30, 0, 8, 2, 951, N'5 Mill', 4, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0004', N'Marc Bartra', N'#RLBETIS', N'Defensa', 29, 2, 5, 0, 1925, N'22 Mill', 5, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0005', N'Alfonso Pedraza', N'#RLBETIS', N'Defensa', 23, 0, 1, 0, 784, N'12 Mill', 6, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0006', N'Sidnei', N'#RLBETIS', N'Defensa', 30, 0, 0, 0, 638, N'10 Mill', 12, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0007', N'Álex Moreno', N'#RLBETIS', N'Defensa', 26, 1, 2, 0, 1628, N'7 Mill', 15, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0008', N'Antonio Barragán', N'#RLBETIS', N'Defensa', 32, 0, 3, 0, 549, N'2 Mill', 19, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0009', N'Emerson', N'#RLBETIS', N'Defensa', 21, 3, 6, 0, 1800, N'15 Mill', 22, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0010', N'Aisa Mandi', N'#RLBETIS', N'Defensa', 28, 0, 8, 0, 1767, N'20 Mill', 23, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0011', N'Guido Rodríguez', N'#RLBETIS', N'Centrocampista', 25, 0, 1, 0, 116, N'10 Mill', 21, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0012', N'Javi García ', N'#RLBETIS', N'Centrocampista', 33, 0, 2, 0, 449, N'2 Mill', 3, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0013', N'Nabil Fekir', N'#RLBETIS', N'Centrocampista', 26, 6, 7, 1, 1662, N'40 Mill', 8, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0014', N'Sergio Canales', N'#RLBETIS', N'Centrocampista', 28, 3, 4, 0, 2025, N'25 Mill', 10, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0015', N'Cristian Tello', N'#RLBETIS', N'Centrocampista', 28, 1, 1, 0, 573, N'6 Mill', 11, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0016', N'Willian Carvalho', N'#RLBETIS', N'Centrocampista', 27, 0, 3, 1, 610, N'20 Mill', 14, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0017', N'Joaquín', N'#RLBETIS', N'Centrocampista', 38, 9, 4, 0, 1461, N'2 Mill', 17, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0018', N'Andrés Guardado', N'#RLBETIS', N'Centrocampista', 33, 0, 7, 0, 1351, N'4 Mill', 18, 60)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0019', N'Diego Lainez', N'#RLBETIS', N'Centrocampista', 19, 1, 0, 0, 444, N'10 Mill', 20, 58)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0020', N'Juanmi', N'#RLBETIS', N'Delantero', 26, 0, 0, 0, 75, N'5 Mill', 7, 63)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0021', N'Borja Iglesias', N'#RLBETIS', N'Delantero', 27, 3, 1, 0, 1348, N'20 Mill', 9, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RB0022', N'Loren Morón', N'#RLBETIS', N'Delantero', 26, 10, 2, 1, 1453, N'20 Mill', 16, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0001', N'Sergio Álvarez', N'#RCELTA', N'Portero', 33, 0, 2, 0, 180, N'1,5 Mill', 1, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0002', N'Rubén Blanco', N'#RCELTA', N'Portero', 24, 0, 3, 0, 1890, N'6 ill', 13, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0003', N'Iván Villar', N'#RCELTA', N'Portero', 22, 0, 0, 0, 0, N'300 mil', 25, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0004', N'Hugo Mallo', N'#RCELTA', N'Defensa', 28, 0, 5, 0, 679, N'9 Mill', 2, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0005', N'Kevin Vázquez', N'#RCELTA', N'Defensa', 26, 0, 5, 0, 1301, N'1 Mill', 20, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0006', N'Néstor Araújo', N'#RCELTA', N'Defensa', 28, 1, 6, 0, 1814, N'7 Mill', 4, 87)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0007', N'Joseph Aidoo', N'#RCELTA', N'Defensa', 24, 0, 4, 0, 1686, N'8 Mill', 18, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0008', N'Jeison Murillo', N'#RCELTA', N'Defensa', 27, 0, 1, 0, 360, N'8 Mill', 21, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0009', N'Jorge Saénz', N'#RCELTA', N'Defensa', 23, 0, 1, 1, 131, N'2 Mill', 16, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0010', N'Lucas Olaza', N'#RCELTA', N'Defensa', 25, 1, 3, 0, 1880, N'4 Mill', 15, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0011', N'David Juncá', N'#RCELTA', N'Defensa', 26, 0, 1, 0, 259, N'1,5 Mill', 17, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0012', N'Okay Yokuslu', N'#RCELTA', N'Centrocampista', 25, 0, 2, 0, 1004, N'7,5 Mill', 5, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0013', N'Fran Beltrán', N'#RCELTA', N'Centrocampista', 21, 0, 2, 1, 1153, N'15 Mill', 8, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0014', N'Filip Bradariç', N'#RCELTA', N'Centrocampista', 28, 0, 0, 0, 20, N'4 Mill', 14, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0015', N'Denis Suárez', N'#RCELTA', N'Centrocampista', 26, 1, 2, 0, 1227, N'12 Mill', 6, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0016', N'Rafinha Alcántara', N'#RCELTA', N'Centrocampista', 27, 2, 2, 0, 1311, N'12 Mill', 12, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0017', N'Pape Cheikh', N'#RCELTA', N'Centrocampista', 22, 0, 3, 1, 545, N'7 Mill', 24, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0018', N'Brais Méndez', N'#RCELTA', N'Delantero', 23, 0, 2, 0, 996, N'17,5 Mill', 23, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0019', N'Juan Hernández', N'#RCELTA', N'Delantero', 25, 0, 0, 0, 21, N'800 mil', 7, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0020', N'Pione Sisto', N'#RCELTA', N'Delantero', 25, 2, 1, 0, 661, N'6 Mill', 11, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0021', N'Fedor Smolov', N'#RCELTA', N'Delantero', 30, 0, 1, 0, 100, N'9 Mill', 9, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0022', N'Iago Aspas', N'#RCELTA', N'Delantero', 32, 8, 4, 0, 2067, N'20 Mill', 10, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0023', N'Santi Mina', N'#RCELTA', N'Delantero', 24, 2, 4, 0, 1246, N'18 Mill', 22, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RC0024', N'Gabriel Fernández', N'#RCELTA', N'Delantero', 25, 1, 1, 0, 492, N'3 Mill', 19, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0001', N'Andrés Prieto', N'#RCDESP', N'Portero', 27, 0, 0, 0, 0, N'200 mil', 1, 91)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0002', N'Diego López', N'#RCDESP', N'Portero', 39, 0, 2, 0, 2070, N'1 Mill', 13, 89)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0003', N'Oier', N'#RCDESP', N'Portero', 30, 0, 0, 0, 0, N'2 Mill', 25, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0004', N'Pipa ', N'#RCDESP', N'Defensa', 22, 0, 1, 0, 116, N'500 mil', 2, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0005', N'Pedrosa', N'#RCDESP', N'Defensa', 22, 1, 1, 0, 735, N'10 Mill', 3, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0006', N'Naldo', N'#RCDESP', N'Defensa', 32, 0, 5, 1, 1232, N'2 Mill', 5, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0007', N'Javi López', N'#RCDESP', N'Defensa', 34, 0, 2, 1, 780, N'1 Mill', 16, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0008', N'Dídac Vilá', N'#RCDESP', N'Defensa', 31, 0, 5, 0, 1472, N'4 Mill', 17, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0009', N'Bernardo', N'#RCDESP', N'Defensa', 31, 2, 4, 0, 1260, N'6 Mill', 20, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0010', N'Cabrera', N'#RCDESP', N'Defensa', 28, 0, 0, 0, 1800, N'10 Mill', 18, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0011', N'Calero', N'#RCDESP', N'Defensa', 29, 0, 4, 1, 962, N'5 Mill', 24, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0012', N'Iturraspe', N'#RCDESP', N'Centrocampista', 31, 0, 1, 0, 103, N'10 Mill', 8, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0013', N'Sergi Darder', N'#RCDESP', N'Centrocampista', 27, 2, 1, 0, 1753, N'2,5 Mill', 10, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0014', N'Melendo ', N'#RCDESP', N'Centrocampista', 23, 0, 0, 0, 603, N'7,5 Mill', 14, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0015', N'David López', N'#RCDESP', N'Centrocampista', 31, 2, 2, 0, 1384, N'7,5 Mill', 15, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0016', N'Marc Roca', N'#RCDESP', N'Centrocampista', 24, 2, 5, 0, 1899, N'20 Mill', 21, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0017', N'Embarba', N'#RCDESP', N'Centrocampista', 28, 0, 0, 0, 213, N'7 Mill', 23, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0018', N'Pol Lozano', N'#RCDESP', N'Centrocampista', 21, 0, 0, 0, 17, N'1,5 Mill', 26, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0019', N'Víctor Sánchez', N'#RCDESP', N'Centrocampista', 33, 0, 7, 0, 1337, N'3 Mill', 4, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0020', N'Wu Lei', N'#RCDESP', N'Delantero', 29, 2, 1, 0, 878, N'10 Mill', 7, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0021', N'Ferreyra', N'#RCDESP', N'Delantero', 29, 1, 2, 0, 524, N'4 Mill', 9, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0022', N'Calleri', N'#RCDESP', N'Delantero', 27, 1, 1, 0, 1146, N'7,5 Mill', 12, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0023', N'Matías Vargas', N'#RCDESP', N'Delantero', 23, 0, 1, 0, 942, N'11 Mill', 22, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0024', N'Campuzano', N'#RCDESP', N'Delantero', 23, 0, 2, 0, 695, N'3 Mill', 31, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RE0025', N'RDT', N'#RCDESP', N'Delantero', 26, 4, 1, 0, 360, N'20 Mill', 11, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0001', N'Areola', N'#RMDRID', N'Portero', 26, 0, 0, 0, 270, N'16 Mill', 1, 94)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0002', N'Thibaut Courtois', N'#RMDRID', N'Portero', 27, 0, 0, 0, 1890, N'55 Mill', 13, 96)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0003', N'Daniel Carvajal', N'#RMDRID', N'Defensa', 28, 1, 7, 0, 1800, N'50 Mill', 2, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0004', N'Eder Militao', N'#RMDRID', N'Defensa', 22, 0, 2, 0, 549, N'45 Mill', 3, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0005', N'Sergio Ramos', N'#RMDRID', N'Defensa', 33, 5, 6, 0, 1950, N'18 Mill', 4, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0006', N'Raphael Varane', N'#RMDRID', N'Defensa', 26, 2, 2, 0, 1800, N'80 Mill', 5, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0007', N'Nacho Fernández', N'#RMDRID', N'Defensa', 30, 1, 3, 0, 393, N'15 Mill', 6, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0008', N'Marcelo', N'#RMDRID', N'Defensa', 26, 0, 1, 0, 701, N'20 Mill', 12, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0009', N'Ferland Mendy', N'#RMDRID', N'Defensa', 24, 0, 4, 1, 1099, N'35 Mill', 23, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0010', N'Toni Kroos', N'#RMDRID', N'Centrocampista', 30, 3, 1, 0, 1631, N'60 Mill', 8, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0011', N'Luka Modric', N'#RMDRID', N'Centrocampista', 34, 3, 3, 1, 1184, N'15 Mill', 10, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0012', N'Casemiro', N'#RMDRID', N'Centrocampista', 27, 3, 8, 0, 1950, N'70 Mill', 14, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0013', N'Fede Valverde', N'#RMDRID', N'Centrocampista', 27, 2, 1, 0, 1160, N'50 Mill', 15, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0014', N'James Rodríguez', N'#RMDRID', N'Centrocampista', 28, 1, 1, 0, 341, N'40 Mill', 16, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0016', N'Eden Hazard', N'#RMDRID', N'Delantero', 29, 1, 0, 0, 682, N'120 Mill', 7, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0017', N'Karim Benzema', N'#RMDRID', N'Delantero', 32, 13, 0, 0, 1951, N'40 Mill', 9, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0018', N'Gareth Bale', N'#RMDRID', N'Delantero', 30, 2, 2, 1, 992, N'40 Mill', 11, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0019', N'Lucas Vázquez', N'#RMDRID', N'Delantero', 28, 2, 1, 0, 529, N'20 Mill', 17, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0020', N'Luka Joviç', N'#RMDRID', N'Delantero', 22, 2, 2, 0, 392, N'40 Mill', 18, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0021', N'Marco Asensio', N'#RMDRID', N'Delantero', 24, 0, 0, 0, 0, N'40 Mill', 20, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0022', N'Brahim Díaz', N'#RMDRID', N'Delantero', 20, 0, 0, 0, 23, N'15 Mill', 21, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0023', N'Mariano Díaz', N'#RMDRID', N'Delantero', 26, 0, 0, 0, 0, N'16 Mill', 24, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0024', N'Vinícius Junior', N'#RMDRID', N'Delantero', 19, 1, 2, 0, 698, N'50 Mill', 25, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RM0025', N'Rodrygo Goes', N'#RMDRID', N'Delantero', 19, 2, 0, 0, 666, N'50 Mill', 27, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RMA999', N'Martin Garcia', N'#RMDRID', N'Delantero', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0001', N'Álex Remiro', N'#RSODAD', N'Portero', 24, 0, 0, 0, 1440, N'7,5 Mill', 1, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0002', N'Moyá', N'#RSODAD', N'Portero', 35, 0, 0, 0, 630, N'1,5 Mill', 13, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0003', N'Zaldúa', N'#RSODAD', N'Defensa', 27, 0, 6, 0, 1783, N'12 Mill', 2, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0004', N'Diego Llorente', N'#RSODAD', N'Defensa', 26, 0, 2, 0, 1538, N'25 Mill', 3, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0005', N'Elustondo', N'#RSODAD', N'Defensa', 25, 0, 0, 0, 658, N'10 Mill', 6, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0006', N'Aihen', N'#RSODAD', N'Defensa', 22, 0, 0, 0, 535, N'5 Mill', 12, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0007', N'Monreal', N'#RSODAD', N'Defensa', 33, 1, 1, 0, 1485, N'4 Mill', 20, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0008', N'Le Normand', N'#RSODAD', N'Defensa', 23, 1, 5, 0, 1192, N'5 Mill', 24, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0009', N'Illaramendi', N'#RSODAD', N'Centrocampista', 29, 0, 0, 0, 217, N'18 Mill', 4, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0010', N'Zubeldia', N'#RSODAD', N'Centrocampista', 22, 0, 6, 0, 1714, N'30 Mill', 5, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0011', N'Mikel Merino', N'#RSODAD', N'Centrocampista', 23, 2, 3, 0, 1892, N'20 Mill', 8, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0012', N'Guevara', N'#RSODAD', N'Centrocampista', 22, 0, 3, 0, 824, N'7,5 Mill', 16, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0013', N'Zurutuza', N'#RSODAD', N'Centrocampista', 33, 0, 0, 0, 92, N'2 Mill', 17, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0014', N'Odegaard', N'#RSODAD', N'Centrocampista', 21, 4, 3, 0, 1743, N'50 Mill', 21, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0015', N'Luca Sangalli', N'#RSODAD', N'Centrocampista', 25, 0, 0, 0, 302, N'3 Mill', 23, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0016', N'Willian Jose', N'#RSODAD', N'Delantero', 28, 8, 4, 0, 1312, N'30 Mill', 9, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0017', N'Mikel Oyarzabal', N'#RSODAD', N'Delantero', 22, 7, 2, 0, 1882, N'60 Mill', 10, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0018', N'Adnan Yanuzaj', N'#RSODAD', N'Delantero', 25, 0, 1, 0, 573, N'12 Mill', 11, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0019', N'Portu', N'#RSODAD', N'Delantero', 27, 7, 5, 0, 1664, N'15 Mill', 7, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0020', N'Isak', N'#RSODAD', N'Delantero', 20, 7, 3, 0, 822, N'25 Mill', 19, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RS0021', N'Barrenetxea', N'#RSODAD', N'Delantero', 18, 1, 0, 0, 137, N'10 Mill', 22, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0001', N'Jordi Masip', N'#RVDLID', N'Portero', 31, 0, 2, 0, 2160, N'6 Mill', 1, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0002', N'José Antonio Caro', N'#RVDLID', N'Portero', 25, 0, 0, 0, 0, N'600 mil', 13, 88)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0003', N'Pedro Porro', N'#RVDLID', N'Defensa', 20, 0, 1, 0, 629, N'10 Mill', 2, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0004', N'Kiko Olivas', N'#RVDLID', N'Defensa', 31, 1, 1, 0, 2160, N'2,5 Mill', 4, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0005', N'Javi Sánchez', N'#RVDLID', N'Defensa', 22, 0, 0, 0, 0, N'1,5 Mill', 5, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0006', N'Raúl Carnero', N'#RVDLID', N'Defensa', 30, 0, 0, 0, 1620, N'1 Mill', 6, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0007', N'Javi Moyano', N'#RVDLID', N'Defensa', 33, 0, 3, 0, 1421, N'800 mil', 17, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0008', N'Antoñito', N'#RVDLID', N'Defensa', 32, 0, 1, 0, 519, N'1 Mill', 18, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0009', N'Nacho Martínez', N'#RVDLID', N'Defensa', 30, 0, 2, 0, 1087, N'5 Mill', 22, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0010', N'Joaquín Fernández', N'#RVDLID', N'Defensa', 23, 1, 7, 0, 1012, N'3 Mill', 24, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0011', N'Salisu', N'#RVDLID', N'Defensa', 20, 0, 2, 0, 2096, N'10 Mill', 27, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0012', N'Ben Arfa', N'#RVDLID', N'Centrocampista', 32, 0, 0, 0, 12, N'5 Mill', 3, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0013', N'Matheus Fernandes', N'#RVDLID', N'Centrocampista', 21, 0, 0, 0, 0, N'3,5 Mill', 8, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0014', N'Óscar Plano', N'#RVDLID', N'Centrocampista', 29, 3, 3, 0, 1788, N'4 Mill', 10, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0015', N'Pablo Hervías', N'#RVDLID', N'Centrocampista', 26, 1, 0, 0, 421, N'800 mil', 11, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0016', N'Rubén Alcaraz', N'#RVDLID', N'Centrocampista', 28, 1, 7, 0, 990, N'10 Mill', 14, 81)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0017', N'San Emeterio', N'#RVDLID', N'Centrocampista', 22, 0, 3, 0, 976, N'4 Mill', 16, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0018', N'Toni Villa', N'#RVDLID', N'Centrocampista', 25, 0, 4, 0, 1001, N'4 Mill', 19, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0019', N'Míchel Herrero', N'#RVDLID', N'Centrocampista', 31, 1, 4, 0, 1679, N'2 Mill', 21, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0020', N'Waldo Rubio', N'#RVDLID', N'Centrocampista', 24, 0, 3, 0, 443, N'1 Mill', 23, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0021', N'Sergi Guardiola', N'#RVDLID', N'Delantero', 28, 5, 4, 0, 1880, N'3 Mill', 7, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0022', N'Enes Ünal', N'#RVDLID', N'Delantero', 22, 4, 2, 0, 1439, N'4 Mill', 9, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'RV0023', N'Sandro Ramírez', N'#RVDLID', N'Delantero', 24, 1, 2, 0, 879, N'4 Mill', 20, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0001', N'Vaclik', N'#SVILLA', N'Portero', 30, 0, 0, 0, 2160, N'18 Mill', 1, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0002', N'Bounou', N'#SVILLA', N'Portero', 28, 0, 0, 0, 0, N'5 Mill', 13, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0003', N'Sergio Escudero', N'#SVILLA', N'Defensa', 30, 0, 2, 0, 324, N'6 Mill', 18, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0004', N'Jesús Navas', N'#SVILLA', N'Defensa', 34, 0, 2, 0, 2159, N'4 Mill', 16, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0005', N'Daniel Carriço', N'#SVILLA', N'Defensa', 31, 0, 3, 0, 848, N'2,5 Mill', 6, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0006', N'Sergi Gómez', N'#SVILLA', N'Defensa', 27, 0, 2, 0, 367, N'5 Mill', 3, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0007', N'Diego Carlos', N'#SVILLA', N'Defensa', 26, 2, 5, 0, 2055, N'25 Mill', 20, 79)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0008', N'Koundé', N'#SVILLA', N'Defensa', 21, 0, 2, 0, 1136, N'25 Mill', 12, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0009', N'Sergio Reguilón', N'#SVILLA', N'Defensa', 23, 1, 5, 0, 1693, N'22 Mill', 23, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0010', N'Franco Vázquez', N'#SVILLA', N'Centrocampista', 30, 3, 4, 0, 810, N'12 Mill', 22, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0011', N'Éver Banega', N'#SVILLA', N'Centrocampista', 31, 2, 5, 0, 1767, N'9 Mill', 10, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0012', N'Joan Jordán', N'#SVILLA', N'Centrocampista', 25, 2, 4, 0, 1375, N'18 Mill', 24, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0013', N'Lucas Ocampos', N'#SVILLA', N'Centrocampista', 25, 7, 5, 0, 1654, N'25 Mill', 5, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0014', N'Oliver Torres', N'#SVILLA', N'Centrocampista', 25, 1, 4, 0, 1013, N'17 Mill', 21, 63)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0015', N'Fernando', N'#SVILLA', N'Centrocampista', 32, 0, 9, 0, 1980, N'7 Mill', 25, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0016', N'Gudelj', N'#SVILLA', N'Centrocampista', 28, 0, 4, 0, 462, N'7 Mill', 17, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0017', N'Rony Lopes', N'#SVILLA', N'Centrocampista', 24, 0, 0, 0, 21, N'12,5 Mill', 7, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0018', N'Suso', N'#SVILLA', N'Delantero', 26, 1, 0, 0, 195, N'22 Mill', 14, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0019', N'Nolito', N'#SVILLA', N'Delantero', 33, 3, 0, 0, 904, N'2 Mill', 8, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0020', N'Munir', N'#SVILLA', N'Delantero', 24, 2, 1, 0, 643, N'11 Mill', 11, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0021', N'Luuk De Jong', N'#SVILLA', N'Delantero', 29, 4, 2, 0, 1422, N'12 Mill', 19, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'SV0022', N'En-Nesyri', N'#SVILLA', N'Delantero', 22, 5, 2, 0, 1587, N'15 Mill', 15, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0001', N'Sergio Asenjo', N'#VLLARL', N'Portero', 30, 0, 1, 0, 1890, N'12 Mill', 1, 85)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0002', N'Andrés Fernández', N'#VLLARL', N'Portero', 33, 0, 1, 0, 270, N'1 Mill', 13, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0003', N'Mario Gaspar', N'#VLLARL', N'Defensa', 29, 0, 2, 0, 1410, N'7,5 Mill', 2, 71)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0004', N'Raúl Albiol', N'#VLLARL', N'Defensa', 34, 1, 8, 0, 2068, N'4 Mill', 3, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0005', N'Pau Torres', N'#VLLARL', N'Defensa', 23, 1, 3, 0, 1801, N'15 Mill', 4, 80)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0006', N'Funes Mori', N'#VLLARL', N'Defensa', 28, 0, 1, 0, 452, N'6 Mill', 6, 82)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0007', N'Alberto Moreno', N'#VLLARL', N'Defensa', 27, 0, 1, 0, 413, N'7,5 Mill', 18, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0008', N'Xavi Quintillá', N'#VLLARL', N'Defensa', 23, 0, 5, 0, 1373, N'5 Mill', 16, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0009', N'Rubén Peña', N'#VLLARL', N'Defensa', 28, 1, 3, 0, 1148, N'8 Mill', 20, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0010', N'Zambo Anguissa', N'#VLLARL', N'Centrocampista', 24, 1, 5, 0, 1640, N'25 Mill', 19, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0011', N'Bruno Soriano', N'#VLLARL', N'Centrocampista', 35, 0, 0, 0, 945, N'600 mil', 21, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0012', N'Manu Trigueros', N'#VLLARL', N'Centrocampista', 28, 1, 4, 0, 964, N'12 Mill', 14, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0013', N'Iborra', N'#VLLARL', N'Centrocampista', 32, 0, 7, 0, 1903, N'7,5 Mill', 10, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0014', N'Santi Cazorla', N'#VLLARL', N'Centrocampista', 35, 8, 2, 0, 1582, N'4 Mill', 8, 67)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0015', N'Ontiveros', N'#VLLARL', N'Centrocampista', 22, 2, 1, 0, 316, N'9 Mill', 24, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0016', N'Moi Gómez', N'#VLLARL', N'Centrocampista', 25, 4, 1, 0, 1614, N'6 Mill', 23, 65)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0017', N'Chukwueze', N'#VLLARL', N'Delantero', 20, 3, 0, 0, 1353, N'30 Mill', 11, 70)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0018', N'Paco Alcácer', N'#VLLARL', N'Delantero', 26, 1, 0, 0, 226, N'42 Mill', 17, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0019', N'Gerard Moreno', N'#VLLARL', N'Delantero', 27, 10, 2, 0, 1819, N'20 Mill', 7, 75)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VI0020', N'Carlos Bacca', N'#VLLARL', N'Delantero', 33, 1, 1, 0, 419, N'3 Mill', 9, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0001', N'Jaume Doménech', N'#VLNCIA', N'Portero', 29, 0, 1, 0, 963, N'7,5 Mill', 1, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0002', N'Jasper Cillesen', N'#VLNCIA', N'Portero', 30, 0, 1, 0, 1197, N'18 Mill', 13, 83)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0003', N'Thierry Correia', N'#VLNCIA', N'Defensa', 20, 0, 0, 0, 180, N'3 Mill', 2, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0004', N'Jaume Costa', N'#VLNCIA', N'Defensa', 31, 0, 1, 1, 871, N'4 Mill', 3, 62)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0005', N'Eliaquim Mangala', N'#VLNCIA', N'Defensa', 29, 0, 1, 0, 270, N'7,5 Mill', 4, 84)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0006', N'Gabriel Paulista', N'#VLNCIA', N'Defensa', 29, 1, 5, 0, 1905, N'22 Mill', 5, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0007', N'Diakhaby', N'#VLNCIA', N'Defensa', 23, 0, 2, 0, 734, N'30 Mill', 12, 78)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0008', N'Jose Gayá', N'#VLNCIA', N'Defensa', 24, 0, 2, 0, 1498, N'50 Mill', 14, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0009', N'Cristiano Piccini', N'#VLNCIA', N'Defensa', 27, 0, 0, 0, 75, N'7,5 Mill', 21, 86)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0010', N'Ezequiel Garay', N'#VLNCIA', N'Defensa', 33, 0, 2, 0, 1438, N'8 Mill', 24, 90)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0011', N'Alessandro Florenzi', N'#VLNCIA', N'Defensa', 28, 0, 1, 0, 131, N'20 Mill', 25, 66)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0012', N'Kondogbia', N'#VLNCIA', N'Centrocampista', 27, 1, 3, 0, 947, N'28 Mill', 6, 76)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0013', N'Guedes', N'#VLNCIA', N'Centrocampista', 23, 0, 0, 0, 535, N'28 Mill', 7, 64)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0014', N'Carlos Soler', N'#VLNCIA', N'Centrocampista', 23, 2, 3, 0, 1136, N'50 Mill', 8, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0015', N'Parejo', N'#VLNCIA', N'Centrocampista', 30, 6, 4, 0, 1941, N'35 Mill', 10, 73)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0016', N'Cheryshev', N'#VLNCIA', N'Centrocampista', 29, 1, 5, 0, 270, N'6 Mill', 11, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0017', N'Kang-In Lee', N'#VLNCIA', N'Centrocampista', 19, 1, 1, 0, 509, N'20 Mill', 16, 68)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0018', N'Coquelin', N'#VLNCIA', N'Centrocampista', 28, 0, 0, 0, 1456, N'24 Mill', 17, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0019', N'Daniel Wass', N'#VLNCIA', N'Centrocampista', 30, 1, 5, 0, 1897, N'14 Mill', 18, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0020', N'Ferrán Torres', N'#VLNCIA', N'Delantero', 19, 0, 4, 1, 1607, N'40 Mill', 20, 77)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0021', N'Gameiro', N'#VLNCIA', N'Delantero', 32, 4, 0, 0, 812, N'8 Mill', 9, 69)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0022', N'Manu Vallejo', N'#VLNCIA', N'Delantero', 23, 1, 0, 0, 315, N'6 Mill', 15, 72)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0023', N'Rodrigo', N'#VLNCIA', N'Delantero', 28, 2, 2, 0, 1367, N'50 Mill', 19, 74)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0024', N'Maxi Gómez', N'#VLNCIA', N'Delantero', 23, 9, 5, 0, 1463, N'40 Mill', 22, 91)
GO
INSERT [dbo].[Futbolistas] ([Codigo], [Nombre], [CodigoEquipo], [Posicion], [Edad], [Goles], [TA], [TR], [Minutos], [PrecioMercado], [Dorsal], [Peso]) VALUES (N'VL0025', N'Rubén Sobrino', N'#VLNCIA', N'Delantero', 27, 1, 0, 0, 118, N'3 Mill', 23, 73)
GO
