CREATE TABLE [�����] (
	-- ���������� ������������� �����
	[DoctorID] INTEGER NOT NULL IDENTITY UNIQUE,
	-- ��� �����
	[FirstName] VARCHAR NOT NULL,
	-- ������� �����
	[LastName] VARCHAR NOT NULL,
	-- ������������� ����� (��������, ���������)
	[Specializ] VARCHAR NOT NULL,
	-- ����� ��������
	[PhoneNumber] VARCHAR(20) NOT NULL,
	-- ����������� �����
	[Email] VARCHAR NOT NULL,
	-- ����� ��������, ��� ��������� ����
	[OfficeNumber] VARCHAR(10) NOT NULL,
	PRIMARY KEY([DoctorID])
);