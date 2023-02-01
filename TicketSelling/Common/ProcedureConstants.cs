using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.Common
{
    public class ProcedureConstants
    {
        #region dbuser


        public static string SP_NewUserSave = @"IF EXISTS (SELECT * FROM TblUser WHERE Username = @Username
                                                      )
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblUser
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO [dbo].[TblUser] ([Name]
                                                      , [Username]
                                                      , [Password]
                                                      , [PhoneNumber]
                                                      , [Gmail])
                                                        VALUES (@Name, @Username, @Password, @PhoneNumber, @Gmail);

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblUser
                                                      WHERE Username = @Username
                                                    END";

        public static string GetAllUser = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblUser WITH (NOLOCK)";

        public static string UpdateUser = @"IF EXISTS (SELECT * FROM TblUser WHERE Username = @Username
                                                     AND Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblUser
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblUser]
														   SET [Name] = @Name
															  ,[Username] = @Username
															  ,[Password] = @Password
															  ,[PhoneNumber] = @PhoneNumber
                                                              ,[Gmail] = @Gmail
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblUser
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END";

        public static string DeleteUser = @"DELETE TblUser WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblUser;";


        #endregion


        #region dbSeatType

        public static string GetAllSeatType = @"SELECT  ROW_NUMBER() OVER(ORDER BY Name ASC) AS RowNumber,* FROM TblSeatType WITH (NOLOCK) ORDER BY Name";

        public static string SP_NewSeatTypeSave = @"IF EXISTS (SELECT * FROM TblSeatType WHERE Name = @Name)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeatType
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblSeatType]
                                                        ([Name]
                                                     , [Note]
                                                       ,[CreatedBy]
													   ,[CreatedDate])
                                                       VALUES(@Name, @Note , @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeatType
                                                      WHERE Name = @Name
                                                    END";

        public static string DeleteSeatType = @"DELETE TblSeatType WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblSeatType;";

        public static string UpdateSeatType = @"IF EXISTS (SELECT * FROM TblSeatType WHERE Name = @Name
                                                       AND Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeatType
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblSeatType]
														   SET [Name] = @Name
															  ,[Note] = @Note
                                                              ,[ModifiedBy] = @UserId
                                                              ,[ModifiedDate] = GETDATE()
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeatType
                                                      WHERE Name = @Name
                                                    END";


        #endregion


        #region dbSeat

        public static string GetSTNoteById = @"Select * from TblSeatType where Id=@Id";

        public static string GetAllSeat = @"SELECT  ROW_NUMBER() OVER(ORDER BY SeatTypeId ASC) AS RowNumber,* FROM TblSeat WITH (NOLOCK) ORDER BY SeatTypeId";

        public static string SaveSeat = @"IF EXISTS (SELECT * FROM TblSeat WHERE Name = @Name)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeat
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblSeat]
                                                        ([Name]
                                                       ,[Price]
                                                       ,[SeatTypeId]
                                                       ,[NumberOfSeat]
                                                       ,[CreatedBy]
													   ,[CreatedDate])
                                                       VALUES(@Name, @Price , @SeatTypeId, @NumberOfSeat , @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeat
                                                      WHERE Name = @Name
                                                    END";

        public static string DeleteSeat = @"DELETE TblSeat WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblSeat;";

        public static string DeleteSeatbySeatTypeId = @"DELETE TblSeat WHERE SeatTypeId = @SeatTypeId;";

        public static string GetNumberOfSeatBySeatTypeId = @"SELECT COUNT(*) NumberOfSeat FROM TblSeat where SeatTypeId=@SeatTypeId";

        public static string GetSeatId = @"SELECT * FROM TblSeat where SeatTypeId=@SeatTypeId";

        public static string GetSeatCountBySeatTypeId = @"SELECT COUNT(Id) Count FROM  TblSeat where SeatTypeId=@SeatTypeId;";//Control delete seattype when seat are assign

        public static string GetAllSeatForTicket = @"SELECT  ROW_NUMBER() OVER(ORDER BY SeatTypeId ASC) AS RowNumber,* FROM TblSeat S  WITH (NOLOCK) 
                                                    inner join TblSeatType ST on S.SeatTypeId = ST.Id
                                                    ORDER BY SeatTypeId";

        public static string GetCustomerSeatCountBySeatTypeId = @"SELECT COUNT(Id) Count FROM  TblSaleDetail where SeatTypeId=@Id;";//Control delete seat when Ticket are assign


        #endregion


        #region dbAdmin

        public static string SP_AdminSave = @"IF EXISTS (SELECT * FROM TblAdmin WHERE Username = @Username)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Username = @Username
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblAdmin]
                                                        ([Name]
                                                        , [Username]
                                                        , [RoleId]
                                                        , [Password]
                                                        , [Gmail]
                                                        , [PhoneNumber]
                                                        , [NRC]
                                                        , [Address]
                                                        , [City]
                                                        , [Postcode]
                                                       ,[CreatedBy]
													   ,[CreatedDate])
                                                       VALUES(@Name, @Username, @RoleId, @Password, @Gmail, @PhoneNumber, @NRC, @Address, @City, @Postcode, @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Username = @Username
                                                    END";

        public static string UpdateAdminPhoto = @"Update TblAdmin set Photo=@Photo where Id=@Id;
                                                    SELECT
                                                    '000' AS RespCode,
                                                    'Successful Message' AS RespDesp,
                                                    'MI' AS 'RespMessageType'
                                                    SELECT
                                                    *
                                                    FROM TblAdmin
                                                    WHERE  Id=@Id
                                                    ";

        public static string GetAllAdmin = @"SELECT
                                                ROW_NUMBER() OVER (ORDER BY A.Id ASC) AS RowNumber,
                                                A.Id,
                                                Photo,
                                                Name,
                                                RoleName,
                                                A.RoleId,
                                                Username,
                                                Password,
                                                Gmail,
                                                PhoneNumber,
                                                NRC,
                                                Address,
                                                City,
                                                Postcode
                                                FROM TblAdmin AS A WITH (NOLOCK)
                                                INNER JOIN TblRole AS R
                                                ON A.RoleId = R.Id";

        public static string UpdateAdmin = @"IF EXISTS (SELECT * FROM TblAdmin WHERE Username = @Username
                                                       AND Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Username = @Username
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblAdmin]
														   SET [Name] =  @Name
                                                        , [RoleId] = @RoleId
                                                        , [Username] = @Username
                                                        , [Password] = @Password
                                                        , [Gmail] = @Gmail
                                                        , [PhoneNumber] = @PhoneNumber
                                                        , [NRC] = @NRC
                                                        , [Address] = @Address
                                                        , [City] = @City
                                                        , [Postcode] = @Postcode
                                                        ,[ModifiedBy] = @UserId
                                                        ,[ModifiedDate] = GETDATE()
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                    END";

        public static string DeleteAdmin = @"DELETE TblAdmin WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblAdmin;";

        public static string GetAllRole = @"SELECT * FROM TblRole";

        public static string CheckUserRoleAndCountById = @"SELECT Count(Id) FROM TBLAdmin WITH(NOLOCK) WHERE RoleId=1;
                                                    SELECT RoleId FROM TblAdmin WHERE Id=@Id;";  //Control delete when only one admin

        #endregion


        #region dbMovie

        public static string SP_MovieSave = @"IF EXISTS (SELECT * FROM TblMovie WHERE Name = @Name AND  Finish IS NULL)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                     
                                                      SELECT
                                                        Max(Id) Id,Name
                                                      FROM TblMovie
                                                      WHERE Name = @Name GROUP BY Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblMovie]
                                                        ([Name]
                                                        , [Casts]
                                                        , [Runtime]
                                                        , [MovieType]
                                                        , [Description]
                                                        , [TrailerLink]
                                                       ,[CreatedBy]
                                                       ,[CreatedDate])
                                                       VALUES(@Name, @Casts, @Runtime, @MovieType, @Description, @TrailerLink , @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        Max(Id) Id,Name
                                                      FROM TblMovie
                                                      WHERE Name = @Name GROUP BY Name
                                                    END";

        public static string UpdateMovieCover = @"Update TblMovie set MovieCover=@MovieCover where Id=@Id;
                                                    SELECT
                                                    '000' AS RespCode,
                                                    'Successful Message' AS RespDesp,
                                                    'MI' AS 'RespMessageType'
                                                    SELECT
                                                    *
                                                    FROM TblMovie
                                                    WHERE  Id=@Id
                                                    ";

        public static string GetAllMovie = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblMovie WITH (NOLOCK) WHERE Finish IS NULL";

        public static string UpdateMovie = @"IF EXISTS (SELECT * FROM TblMovie WHERE Name = @Name
                                                       AND Id != @Id AND  Finish IS NULL)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblMovie
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblMovie]
														   SET [Name] =  @Name
                                                        , [MovieCover] = @MovieCover
                                                        , [Casts] = @Casts
                                                        , [Runtime] = @Runtime
                                                        , [MovieType] = @MovieType
                                                        , [Description] = @Description
                                                        , [TrailerLink] = @TrailerLink
                                                        ,[ModifiedBy] = @UserId
                                                        ,[ModifiedDate] = GETDATE()
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblMovie
                                                      WHERE Name = @Name
                                                    END";

        public static string DeleteMovie = @"DELETE TblMovie WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblMovie;";

        public static string MovieFinish = @"UPDATE TblMovie SET Finish='Finish' WHERE Id = @Id;
                                                SELECT
                                                '000' AS RespCode,
                                                'Movie Finished Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblMovie;";

        public static string GetMovieCountByMovieId = @"SELECT COUNT(Id) Count FROM  TblScheduleMovie where MovieId=@MovieId;"; //Control delete Movie when date are assign

        public static string GetMovieDateCountByTimeId = @"SELECT COUNT(Id) Count FROM  TblScheduleMovieTime where MovieId=@MovieId;"; //Control delete date when time are assign

        public static string GetMovieName = @"SELECT * FROM TblMovie WITH(NOLOCK) WHERE Finish Is NULL";

        public static string GetMovieDateByDateForTicket = @"SELECT * FROM TblScheduleMovieTime where CONVERT(char(10),Date,111) = CONVERT(char(10),@Date,111)";

        public static string GetMovieTimeCountById = @"SELECT COUNT(Id) Count FROM  TblSaleHead where MovieTime=@Id;"; //Control delete time when Ticket are selling

        public static string GetMovieNameForReport = @"SELECT * FROM TblMovie WITH(NOLOCK)";

        #endregion


        #region MovieScheduleDate

        public static string SaveMovieSD = @"IF EXISTS (SELECT * FROM TblScheduleMovie WHERE MovieId = @MovieId)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovie
                                                      WHERE MovieId = @MovieId
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblScheduleMovie]
                                                        ([MovieId]
                                                        ,[StartDate]
                                                        ,[EndDate]
                                                       ,[CreatedBy]
													   ,[CreatedDate])
                                                       VALUES(@MovieId, @StartDate , @EndDate , @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovie
                                                      WHERE MovieId = @MovieId
                                                    END";

        public static string GetMovieNameById = @"Select * from TblMovie where Id=@Id";

        public static string GetAllMovieSD = @"SELECT
                                                ROW_NUMBER() OVER(ORDER BY SM.Id ASC) AS RowNumber,
                                                SM.Id,
                                                Name,
                                                SM.MovieId,
                                                StartDate,
                                                EndDate
                                                FROM TblScheduleMovie AS SM WITH(NOLOCK)
                                                INNER JOIN TblMovie AS M
                                                ON SM.MovieId = M.Id
                                                WHERE M.Finish IS NULL";   //inner join movie with schedule date to show name on Schedule date's data grid view

        public static string DeleteMovieSD = @"DELETE TblScheduleMovie WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblScheduleMovie;";

        public static string UpdateMovieSD = @"IF EXISTS (SELECT * FROM TblScheduleMovie WHERE MovieId = @MovieId AND
                                                        Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovie
                                                      WHERE MovieId = @MovieId
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblScheduleMovie]
														   SET [MovieId] = @MovieId
															  ,[StartDate] = @StartDate
                                                              ,[EndDate]= @EndDate
                                                              ,[ModifiedBy] = @UserId
                                                              ,[ModifiedDate] = GETDATE()
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovie
                                                      WHERE MovieId = @MovieId
                                                    END";


        #endregion

        #region dbMovieScheduleTime

        public static string GetMovieDateById = @"SELECT * FROM TblScheduleMovie where MovieId = @MovieId";

        public static string DeleteMovieST = @"DELETE TblScheduleMovieTime WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblScheduleMovieTime;";

        public static string GetAllMovieST = @"SELECT
                                                ROW_NUMBER() OVER (ORDER BY SMT.Id ASC) AS RowNumber,
                                                SMT.Id,
                                                Name,
                                                SMT.MovieId,
                                                Date,
                                                Time
                                                FROM TblScheduleMovieTime AS SMT WITH (NOLOCK)
                                                INNER JOIN TblMovie AS M
                                                ON SMT.MovieId = M.Id WHERE M.Finish IS NULL";

        public static string SaveMovieST = @"IF EXISTS (SELECT * FROM TblScheduleMovieTime WHERE MovieId = @MovieId AND Time = @Time AND Date = @Date)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovieTime
                                                      WHERE MovieId = @MovieId
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblScheduleMovieTime]
                                                        ([MovieId]
                                                        ,[Date]
                                                        ,[Time]
                                                       ,[CreatedBy]
													   ,[CreatedDate])
                                                       VALUES(@MovieId, @Date , @Time , @CreatedBy, GETDATE());

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovieTime
                                                      WHERE MovieId = @MovieId
                                                    END";

        public static string UpdateMovieST = @"IF EXISTS (SELECT * FROM TblScheduleMovieTime WHERE MovieId = @MovieId AND Time = @Time AND Date = @Date)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovieTime
                                                      WHERE MovieId = @MovieId
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblScheduleMovieTime]
														   SET [MovieId] = @MovieId
															  ,[Date] = @Date
                                                              ,[Time]= @Time
                                                              ,[ModifiedBy] = @UserId
                                                              ,[ModifiedDate] = GETDATE()
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovieTime
                                                      WHERE MovieId = @MovieId
                                                    END";

        #endregion

        public static string LoginUser = @"IF EXISTS(SELECT * FROM TblUser where Username=@Username AND Password=@Password)
                                        BEGIN
                                            SELECT
                                            '000' AS RespCode,
                                            'Login Successful. Welcome Back!' AS RespDesp,
                                            'MI' AS 'RespMessageType'
                                        END
                                        ELSE
                                        BEGIN
                                            SELECT
                                            '001' AS RespCode,
                                            'Invalid Username and Password' AS RespDesp,
                                            'ME' AS 'RespMessageType'
                                        END";

        public static string Login = @"IF EXISTS(SELECT * FROM TblAdmin where Username=@Username AND Password=@Password)
                                        BEGIN
                                             SELECT * FROM TblAdmin  where Username=@Username AND Password=@Password;
                                        END
                                        ELSE
                                        BEGIN
                                            SELECT
                                            '001' AS RespCode,
                                            'Invalid Username and Password' AS RespDesp,
                                            'ME' AS 'RespMessageType'
                                        END";



        #region dashboard


        public static string GetAllMovieDB = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblMovie WITH (NOLOCK) WHERE Finish IS NULL";

        #endregion

        #region Ticket Selling

        public static string SaveSaleHead = @"INSERT INTO [dbo].[TblSaleHead]
                                                           ([MovieId]
                                                           ,[MovieDate]
                                                           ,[MovieTime]
                                                           ,[CustomerName]
                                                           ,[Phone]
                                                           ,[TotalPrice]
                                                           ,[CreatedBy]
                                                           ,[CreatedDate])
                                                     VALUES
                                                           (@MovieId
                                                           ,@MovieDate 
                                                           ,@MovieTime
                                                           ,@CustomerName
                                                           ,@Phone
                                                           ,@TotalPrice
                                                           ,@CreatedBy
                                                           ,GETDATE());

                                                SELECT * FROM TblSaleHead WHERE Id IN ( SELECT Max(Id) FROM TblSaleHead);";

        public static string SaveSaleDetail = @"INSERT INTO [dbo].[TblSaleDetail]
                                                ([HeadId]
                                                ,[SeatTypeId]
                                                ,[SeatId]
                                                ,[Price])
                                                VALUES
                                                (@HeadId
                                                ,@SeatTypeId
                                                ,@SeatId
                                                ,@Price);

                                                SELECT
                                                '000' AS RespCode,
                                                'Successful Message' AS RespDesp,
                                                'MI' AS 'RespMessageType';
	
                                                SELECT * FROM TblSaleDetail WHERE HeadId=@HeadId;";

        public static string GetSellingTicket = @"SELECT HeadId,SeatTypeId,SeatId,Price FROM TblSaleHead H inner join TblSaleDetail D on H.Id = D.HeadId WHERE MovieId=@MovieId AND CONVERT(char(10),MovieDate,111)=CONVERT(char(10),@MovieDate,111) AND MovieTime=@MovieTime;";

        #endregion

        #region Report

        public static string SP_GetSaleReportByDate = @"SELECT  ROW_NUMBER() OVER(ORDER BY D.HeadId ASC) AS RowNumber,
                                                          M.Name MovieName,
                                                          MovieDate,
                                                          MT.Time MovieTime,
                                                          S.Name SeatName,
                                                          D.Price,
                                                          TotalPrice
                                                        FROM TblSaleHead H
                                                        INNER JOIN TblSaleDetail D
                                                          ON H.Id = D.HeadId
                                                        INNER JOIN TblMovie M
                                                          ON H.MovieId = M.Id
                                                        INNER JOIN TblScheduleMovieTime MT
                                                          ON H.MovieTime = MT.Id
                                                        INNER JOIN TblSeat S
                                                          ON D.SeatId = S.Id
                                                        WHERE CONVERT(char(10), MovieDate, 111) = CONVERT(char(10), @StartDate, 111) AND M.Id=@MovieId ORDER By MovieDate";


        public static string SP_GetSaleReportByWeek = @"SELECT  ROW_NUMBER() OVER(ORDER BY D.HeadId ASC) AS RowNumber,
                                                          M.Name MovieName,
                                                          MovieDate,
                                                          MT.Time MovieTime,
                                                          S.Name SeatName,
                                                          D.Price,
                                                          TotalPrice
                                                        FROM TblSaleHead H
                                                        INNER JOIN TblSaleDetail D
                                                          ON H.Id = D.HeadId
                                                        INNER JOIN TblMovie M
                                                          ON H.MovieId = M.Id
                                                        INNER JOIN TblScheduleMovieTime MT
                                                          ON H.MovieTime = MT.Id
                                                        INNER JOIN TblSeat S
                                                          ON D.SeatId = S.Id
                                                        WHERE CONVERT(char(10), MovieDate, 111) BETWEEN CONVERT(char(10), @StartDate, 111) AND  CONVERT(char(10), @EndDate, 111) AND M.Id=@MovieId ORDER By MovieDate";



        public static string SP_GetSaleReportByMonth = @"SELECT  ROW_NUMBER() OVER(ORDER BY D.HeadId ASC) AS RowNumber,
                                                          M.Name MovieName,
                                                          MovieDate,
                                                          MT.Time MovieTime,
                                                          S.Name SeatName,
                                                          D.Price,
                                                          TotalPrice
                                                        FROM TblSaleHead H
                                                        INNER JOIN TblSaleDetail D
                                                          ON H.Id = D.HeadId
                                                        INNER JOIN TblMovie M
                                                          ON H.MovieId = M.Id
                                                        INNER JOIN TblScheduleMovieTime MT
                                                          ON H.MovieTime = MT.Id
                                                        INNER JOIN TblSeat S
                                                          ON D.SeatId = S.Id
                                                        WHERE CONVERT(char(7), MovieDate, 111) = CONVERT(char(7), @StartDate, 111) AND M.Id=@MovieId ORDER By MovieDate";

        #endregion
    }
}
