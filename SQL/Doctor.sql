CREATE TABLE [Врачи] (
	-- Уникальный идентификатор врача
	[DoctorID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- имя врача
	[FirstName] VARCHAR NOT NULL,
	-- фамилия врача
	[LastName] VARCHAR NOT NULL,
	-- Специальность врача (например, кардиолог)
	[Specializ] VARCHAR NOT NULL,
	-- Номер телефона
	[PhoneNumber] VARCHAR(20) NOT NULL,
	-- Электронная почта
	[Email] VARCHAR NOT NULL,
	-- Номер кабинета, где принимает врач
	[OfficeNumber] VARCHAR(10) NOT NULL,
	PRIMARY KEY([DoctorID])
);