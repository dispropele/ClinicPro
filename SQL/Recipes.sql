CREATE TABLE [Recipes] (
	-- Уникальный идентификатор рецепта
	[RecipesID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- Ссылка на медицинскую карту
	[MedCardID] INTEGER NOT NULL,
	-- Название лекарства
	[Medication] VARCHAR NOT NULL,
	-- Дозировка лекарства
	[Dosage] VARCHAR NOT NULL,
	-- Дата начала приема лекарства
	[StartDate] DATE NOT NULL,
	-- Дата окончания приема лекарства
	[EndDate] DATE,
	PRIMARY KEY([RecipesID]),
	FOREIGN KEY (MedCardID) REFERENCES MedCardRecord(MedCardID)
);