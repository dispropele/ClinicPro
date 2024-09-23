CREATE TABLE [MedCardRecord] (
	-- ���������� ������������� ������
	[RecordID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- ����, ��������� ������
	[DoctorID] INTEGER NOT NULL,
	-- ������ �� ����������� �����
	[MedCardID] INTEGER NOT NULL,
	-- ���� ������
	[RecordDate] DATETIME NOT NULL,
	-- �������
	[Diagnosis] VARCHAR NOT NULL,
	-- ����������� �������
	[Treatmeat] TEXT NOT NULL,
	-- ����������� � ������������
	[Comments] TEXT,
	PRIMARY KEY([RecordID]),
	FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
    FOREIGN KEY (MedCardID) REFERENCES MedCard(MedCardID)
);