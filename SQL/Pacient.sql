CREATE TABLE [Пациенты] (
	-- Уникальный идентификатор пациента
    [PatientID] INTEGER NOT NULL IDENTITY PRIMARY KEY,
	-- Ссылка на медицинскую карту
    [MedCardID] INTEGER NOT NULL,
	-- имя пациента
    [FirstName] VARCHAR(255) NOT NULL,
	-- фамилия пациента
    [LastName] VARCHAR(255) NOT NULL,
	-- Дата рождения
    [DateOfBirth] DATE NOT NULL,
	-- Пол ("M", "F", "T")
    [Gender] CHAR(1) NOT NULL,
	-- Номер телефона
    [PhoneNumber] VARCHAR(20) UNIQUE,
	-- Электронная почта
    [Email] VARCHAR(255) UNIQUE NOT NULL
);