CREATE TABLE [dbo].[Course] (
    [CourseName]   NVARCHAR (450) NOT NULL,
    [CourseLevel]  NVARCHAR (30)  NOT NULL,
    [CourseRating] NVARCHAR (30)  NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([CourseName] ASC)
);

