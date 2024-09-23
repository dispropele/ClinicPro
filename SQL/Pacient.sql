CREATE TABLE [��������] (
	-- ���������� ������������� ��������
    [PatientID] INTEGER NOT NULL IDENTITY PRIMARY KEY,
	-- ������ �� ����������� �����
    [MedCardID] INTEGER NOT NULL,
	-- ��� ��������
    [FirstName] VARCHAR(255) NOT NULL,
	-- ������� ��������
    [LastName] VARCHAR(255) NOT NULL,
	-- ���� ��������
    [DateOfBirth] DATE NOT NULL,
	-- ��� ("M", "F", "T")
    [Gender] CHAR(1) NOT NULL,
	-- ����� ��������
    [PhoneNumber] VARCHAR(20) UNIQUE,
	-- ����������� �����
    [Email] VARCHAR(255) UNIQUE NOT NULL
);