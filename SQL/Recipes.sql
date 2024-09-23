CREATE TABLE [Recipes] (
	-- ���������� ������������� �������
	[RecipesID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- ������ �� ����������� �����
	[MedCardID] INTEGER NOT NULL,
	-- �������� ���������
	[Medication] VARCHAR NOT NULL,
	-- ��������� ���������
	[Dosage] VARCHAR NOT NULL,
	-- ���� ������ ������ ���������
	[StartDate] DATE NOT NULL,
	-- ���� ��������� ������ ���������
	[EndDate] DATE,
	PRIMARY KEY([RecipesID]),
	FOREIGN KEY (MedCardID) REFERENCES MedCardRecord(MedCardID)
);