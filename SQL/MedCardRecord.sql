CREATE TABLE [MedCardRecord] (
	-- Уникальный идентификатор записи
	[RecordID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- Врач, сделавший запись
	[DoctorID] INTEGER NOT NULL,
	-- Ссылка на медицинскую карту
	[MedCardID] INTEGER NOT NULL,
	-- Дата записи
	[RecordDate] DATETIME NOT NULL,
	-- Диагноз
	[Diagnosis] VARCHAR NOT NULL,
	-- Назначенное лечение
	[Treatmeat] TEXT NOT NULL,
	-- Комментарии и рекомендации
	[Comments] TEXT,
	PRIMARY KEY([RecordID]),
	FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
    FOREIGN KEY (MedCardID) REFERENCES MedCard(MedCardID)
);