CREATE TABLE Messages
(
    MessageId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Message  NVARCHAR(80) NULL,
    Type NVARCHAR(80) NULL,
    Form NVARCHAR(80) NULL
);

