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

        public static string DeleteSeatbySeatTypeId = @"DELETE TblSeat WHERE SeatTypeId = @SeatTypeId;
";

        public static string GetNumberOfSeatBySeatTypeId = @"SELECT COUNT(*) NumberOfSeat FROM TblSeat where SeatTypeId=@SeatTypeId";

        public static string GetSeatId = @"SELECT * FROM TblSeat where SeatTypeId=@SeatTypeId";

        public static string GetSeatCountBySeatTypeId = @"SELECT COUNT(Id) Count FROM  TblSeat where SeatTypeId=@SeatTypeId;";

        #endregion


        #region Movie
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

        #endregion

        #region MovieScheduleDate

        public static string MovieSDSave = @"IF EXISTS (SELECT * FROM TblScheduleMovie WHERE Name = @Name)
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
                                                      INSERT INTO[dbo].[TblScheduleMovie]
                                                        ([Name]
                                                        , [MovieId]
                                                        , [StartDate]
                                                        , [EndDate]
                                                       ,[CreatedBy])
                                                       VALUES(@Name, @MovieId, @StartDate, @EndDate, @CreatedBy);

                                                        SELECT
                                                        '000' AS RespCode,
                                                        'Successful Message' AS RespDesp,
                                                        'MI' AS 'RespMessageType'
                                                      SELECT
                                                        *
                                                      FROM TblScheduleMovie
                                                      WHERE Name = @Name
                                                    END";

        public static string GetMovieNameById = @"Select * from TblMovie where Id=@Id";

        public static string GetAllMovieSD = @"SELECT  ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber,* FROM TblScheduleMovie WITH (NOLOCK)";

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
    }
}
