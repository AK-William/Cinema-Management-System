using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.Common
{
    public class ProcedureConstants
    {
        #region dbStaff
       

        public static string SP_NewStaffSave = @"IF EXISTS (SELECT * FROM TblStaff WHERE Username = @Username
                                                      AND Password = @Password)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblStaff
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO [dbo].[TblStaff] ([Name]
                                                      , [Username]
                                                      , [Password]
                                                      , [PhoneNumber])
                                                        VALUES (@Name, @Username, @Password, @PhoneNumber);

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblStaff
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END";

        public static string GetAllStaff = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblStaff WITH (NOLOCK)";

        public static string UpdateStaff = @"IF EXISTS (SELECT * FROM TblStaff WHERE Username = @Username
                                                     AND Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblStaff
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblStaff]
														   SET [Name] = @Name
															  ,[Username] = @Username
															  ,[Password] = @Password
															  ,[PhoneNumber] = @PhoneNumber
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblStaff
                                                      WHERE Username = @Username
                                                      AND Password = @Password
                                                    END";

        public static string DeleteStaff = @"DELETE TblStaff WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblStaff;";


        #endregion


        #region dbSeatType

        public static string GetAllSeatType = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblSeatType WITH (NOLOCK)";

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
                                                       ,[CreatedBy])
                                                       VALUES(@Name, @Note , @CreatedBy);

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

        public static string GetAllSeat = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblSeat WITH (NOLOCK)";

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
                                                       ,[CreatedBy])
                                                       VALUES(@Name, @Price , @SeatTypeId , @CreatedBy);

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblSeat
                                                      WHERE Name = @Name
                                                    END";

        public static string UpdateSeat = @"IF EXISTS (SELECT * FROM TblSeat WHERE Name = @Name
                                                       AND Id != @Id)
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
                                                      UPDATE [dbo].[TblSeatType]
														   SET [Name] = @Name
															  ,[Price] = @Price
                                                              ,[SeatTypeId]= @SeatTypeId
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
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

        #endregion


        #region dbAdmin

        public static string SP_AdminSave = @"IF EXISTS (SELECT * FROM TblAdmin WHERE Name = @Name)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      INSERT INTO[dbo].[TblAdmin]
                                                        ([Name]
                                                        , [Username]
                                                        , [Password]
                                                        , [Gmail]
                                                        , [PhoneNumber]
                                                        , [NRC]
                                                        , [Address]
                                                        , [City]
                                                        , [Postcode]
                                                       ,[CreatedBy])
                                                       VALUES(@Name, @Username, @Password, @Gmail, @PhoneNumber, @NRC, @Address, @City, @Postcode, @CreatedBy);

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Name = @Name
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

        public static string GetAllAdmin = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblAdmin WITH (NOLOCK)";

        public static string UpdateAdmin = @"IF EXISTS (SELECT * FROM TblAdmin WHERE Name = @Name
                                                       AND Id != @Id)
                                                    BEGIN
                                                      SELECT
                                                        '001' AS RespCode,
                                                        'Duplicate Error' AS RespDesp,
                                                        'ME' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Name = @Name
                                                    END
                                                    ELSE
                                                    BEGIN
                                                      UPDATE [dbo].[TblAdmin]
														   SET [Name] =  @Name
                                                        , [Username] = @Username
                                                        , [Password] = @Password
                                                        , [Gmail] = @Gmail
                                                        , [PhoneNumber] = @PhoneNumber
                                                        , [NRC] = @NRC
                                                        , [Address] = @Address
                                                        , [City] = @City
                                                        , [Postcode] = @Postcode
														 WHERE Id = @Id 

                                                      SELECT
                                                        '000' AS RespCode,
                                                        'Update Successful' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblAdmin
                                                      WHERE Name = @Name
                                                    END";

        public static string DeleteAdmin = @"DELETE TblAdmin WHERE Id = @Id; 
                                                SELECT
                                                '000' AS RespCode,
                                                'Update Successful' AS RespDesp,
                                                'MI' AS 'RespMessageType'
                                                SELECT
                                                *
                                                FROM TblAdmin;";

        #endregion


        #region dbMovie

        public static string SP_MovieSave = @"IF EXISTS (SELECT * FROM TblMovie WHERE Name = @Name)
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
                                                      INSERT INTO[dbo].[TblMovie]
                                                        ([Name]
                                                        , [Casts]
                                                        , [Runtime]
                                                        , [MovieType]
                                                        , [Description]
                                                        , [TrailerLink]
                                                       ,[CreatedBy])
                                                       VALUES(@Name, @Casts, @Runtime, @MovieType, @Description, @TrailerLink , @CreatedBy);

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblMovie
                                                      WHERE Name = @Name
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

        public static string GetAllMovie = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblMovie WITH (NOLOCK)";

        public static string UpdateMovie = @"IF EXISTS (SELECT * FROM TblMovie WHERE Name = @Name
                                                       AND Id != @Id)
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

        public static string GetMovieCountByMovieId = @"SELECT COUNT(Id) Count FROM  TblScheduleMovie where MovieId=@MovieId;"; //Control delete Movie when date are assign

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
                                                       ,[CreatedBy])
                                                       VALUES(@MovieId, @StartDate , @EndDate , @CreatedBy);

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
                                                ROW_NUMBER() OVER (ORDER BY SM.Id ASC) AS RowNumber,
                                                SM.Id,
                                                Name,
                                                SM.MovieId,
                                                StartDate,
                                                EndDate
                                                FROM TblScheduleMovie AS SM WITH (NOLOCK)
                                                INNER JOIN TblMovie AS M
                                                ON SM.MovieId = M.Id";   //inner join movie with schedule date to show name on Schedule date's data grid view

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
                                                ON SMT.MovieId = M.Id";

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
                                                       ,[CreatedBy])
                                                       VALUES(@MovieId, @Date , @Time , @CreatedBy);

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovieTime
                                                      WHERE MovieId = @MovieId
                                                    END";

        public static string UpdateMovieST = @"IF EXISTS (SELECT * FROM TblScheduleMovieTime WHERE MovieId = @MovieId AND
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
                                                      UPDATE [dbo].[TblScheduleMovieTime]
														   SET [MovieId] = @MovieId
															  ,[Date] = @Date
                                                              ,[Time]= @Time
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



        public static string Login = @"IF EXISTS(SELECT * FROM TblStaff where Username=@Username AND Password=@Password)
                                        BEGIN
                                            SELECT
                                            '000' AS RespCode,
                                            'Login Successful' AS RespDesp,
                                            'MI' AS 'RespMessageType'
                                        END
                                        ELSE
                                        BEGIN
                                            SELECT
                                            '001' AS RespCode,
                                            'Invalid Username and Password' AS RespDesp,
                                            'ME' AS 'RespMessageType'
                                        END";


        #region dashboard


        public static string GetMovieCoverById = @"Select * from TblMovie where Id=@Id";


        #endregion

    }
}
