# IntroductionToEntityFrameworkeCore_hw
�������� 1
�������� ��������� �������� � ������������� ������ ������ � ����� (List< ��� ���� >) ������ � �������.

1. ������� � Product
1) + Id: Guid
2) + Name: string
3) + Cost: double
4) + Description: string
5) + Quantity: int

2. ���������� � User
1) + Id: Guid
2) + Name: string
3) + LastName: string
4) + Login: string
5) + Password: string
6) + Email: string

3. ���������� � Order
1) + Id: Guid
2) + Name: string
3) + Create: datetime
4) + Update: datetime
5) + Description: string
�������� ��� ������ ���������� (10 �������).
������� �� ����� �������� �� �������� > 1, 5, 0, 7
������� �� ������� ������� > 1, 5 �� ���������� Id
������� �� ������� ������� > 0, 7 �� ���������� Name

�������� 2
�������������� Visual Studio, ������� ����� �� �������� Console Application. 
�������: 
���������� �������� ������ ��� ������ � Entity Framework ������� �������� ���� ����� MyDatabaseContext ��
�������������� �������� �������� 1 (����� �����), ��������� ��� ������ � ����� �������� DbSet, 
��������� ������� �������� ����� ����� ��������, �� � � ������� ������, ����� �������� MyDatabaseContext 
���� �������� ���� ������ ����������. �������������, �� ��� ���������� � ����. ������ �� ������� > 1, 5, 0, 7 
� Product/User/Order (��� �����) ��������� �� ����

�������� 3*
�������������� Visual Studio, ������� ����� �� �������� Windows Forms Application. 
�������: 
�������� ����� ���������, �������������� ������ Database First.(ϳ�������� ������� ���� ����� � �������� 2 (����� �����) ) 
������ �� ����� DataGridView � Button ���������� ��������� ��������� ���������� � DataGridView �� ����������� �� Button.