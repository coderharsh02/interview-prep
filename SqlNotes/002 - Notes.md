Sure, I'll prepare a concise set of hand notes for each of the topics and subtopics listed in your syllabus. These notes will include key concepts, examples, and important tips to help you understand and remember the material. Let's start with the first topic, "Complex Queries."

### **1. Complex Queries**

#### **1.1 Joins**
- **Inner Join**: Returns rows that have matching values in both tables.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  INNER JOIN TableB b ON a.id = b.id;
  ```
- **Left Outer Join**: Returns all rows from the left table, and the matched rows from the right table.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  LEFT OUTER JOIN TableB b ON a.id = b.id;
  ```
- **Right Outer Join**: Returns all rows from the right table, and the matched rows from the left table.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  RIGHT OUTER JOIN TableB b ON a.id = b.id;
  ```
- **Full Join**: Returns rows when there is a match in one of the tables.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  FULL OUTER JOIN TableB b ON a.id = b.id;
  ```
- **Cross Join**: Returns the Cartesian product of the two tables.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  CROSS JOIN TableB b;
  ```
- **Self-Join**: A table joined with itself.
  ```sql
  SELECT a.*, b.*
  FROM Employees a
  INNER JOIN Employees b ON a.ManagerID = b.EmployeeID;
  ```
- **Cross Apply & Outer Apply**: Used for applying a table-valued function to each row of the outer table.
  ```sql
  SELECT a.*, b.*
  FROM TableA a
  CROSS APPLY (SELECT * FROM TableB WHERE a.id = b.id) b;

  SELECT a.*, b.*
  FROM TableA a
  OUTER APPLY (SELECT * FROM TableB WHERE a.id = b.id) b;
  ```

#### **1.2 Common Table Expression (CTE)**
- **Basic CTE**:
  ```sql
  WITH CTE AS (
    SELECT id, name FROM Employees WHERE department = 'HR'
  )
  SELECT * FROM CTE;
  ```
- **Recursive CTE**: Used for hierarchical data, like organizational charts.
  ```sql
  WITH RecursiveCTE AS (
    SELECT id, name, manager_id FROM Employees WHERE manager_id IS NULL
    UNION ALL
    SELECT e.id, e.name, e.manager_id
    FROM Employees e
    INNER JOIN RecursiveCTE r ON e.manager_id = r.id
  )
  SELECT * FROM RecursiveCTE;
  ```

#### **1.3 Pivot and Unpivot**
- **Pivot**: Converts rows into columns.
  ```sql
  SELECT * 
  FROM (
    SELECT Year, Quarter, Sales FROM SalesData
  ) AS SourceTable
  PIVOT (
    SUM(Sales) FOR Quarter IN ([Q1], [Q2], [Q3], [Q4])
  ) AS PivotTable;
  ```
- **Unpivot**: Converts columns back into rows.
  ```sql
  SELECT Year, Quarter, Sales
  FROM SalesData
  UNPIVOT (
    Sales FOR Quarter IN (Q1, Q2, Q3, Q4)
  ) AS UnpivotTable;
  ```

#### **1.4 Query Hints**
- **NoLock**: Reads data without acquiring locks.
  ```sql
  SELECT * FROM Employees WITH (NOLOCK);
  ```
- **Tablock**: Acquires a table-level lock.
  ```sql
  SELECT * FROM Employees WITH (TABLOCK);
  ```
- **ForceIndex**: Forces the query to use a specific index.
  ```sql
  SELECT * FROM Employees WITH (INDEX(IndexName));
  ```

#### **1.5 Table Variables**
- **Declaring and Using a Table Variable**:
  ```sql
  DECLARE @TableVar TABLE (ID INT, Name VARCHAR(50));
  INSERT INTO @TableVar (ID, Name) VALUES (1, 'John');
  SELECT * FROM @TableVar;
  ```

#### **1.6 XML and JSON DOM**
- **XML**: Querying XML data.
  ```sql
  DECLARE @xml XML = '<root><employee id="1" name="John"/></root>';
  SELECT @xml.value('(/root/employee/@name)[1]', 'VARCHAR(50)');
  ```
- **JSON**: Querying JSON data.
  ```sql
  DECLARE @json NVARCHAR(MAX) = '{"employees":[{"id":1,"name":"John"}]}';
  SELECT value FROM OPENJSON(@json, '$.employees')
  WITH (id INT, name NVARCHAR(50));
  ```

#### **1.7 Temporary Tables**
- **Local Temporary Table**:
  ```sql
  CREATE TABLE #TempTable (ID INT, Name VARCHAR(50));
  INSERT INTO #TempTable VALUES (1, 'John');
  SELECT * FROM #TempTable;
  DROP TABLE #TempTable;
  ```
- **Global Temporary Table**:
  ```sql
  CREATE TABLE ##GlobalTempTable (ID INT, Name VARCHAR(50));
  INSERT INTO ##GlobalTempTable VALUES (1, 'John');
  SELECT * FROM ##GlobalTempTable;
  DROP TABLE ##GlobalTempTable;
  ```

#### **1.8 Subqueries, Correlated Queries, and Dynamic Queries**
- **Subquery**:
  ```sql
  SELECT Name FROM Employees WHERE ID = (SELECT MAX(ID) FROM Employees);
  ```
- **Correlated Subquery**:
  ```sql
  SELECT e1.Name FROM Employees e1
  WHERE e1.Salary > (SELECT AVG(e2.Salary) FROM Employees e2 WHERE e2.Department = e1.Department);
  ```
- **Dynamic Query**:
  ```sql
  DECLARE @sql NVARCHAR(MAX) = 'SELECT * FROM ' + @TableName;
  EXEC sp_executesql @sql;
  ```

#### **1.9 Functions**
- **Aggregate Functions**: `SUM()`, `AVG()`, `COUNT()`, `MIN()`, `MAX()`.
  ```sql
  SELECT SUM(Salary) FROM Employees WHERE Department = 'HR';
  ```
- **String Functions**: `LEN()`, `SUBSTRING()`, `REPLACE()`, `UPPER()`, `LOWER()`.
  ```sql
  SELECT UPPER(Name) FROM Employees;
  ```
- **Numeric Functions**: `ABS()`, `ROUND()`, `CEILING()`, `FLOOR()`.
  ```sql
  SELECT ROUND(Salary, 2) FROM Employees;
  ```
- **Ranking Functions**: `ROW_NUMBER()`, `RANK()`, `DENSE_RANK()`, `NTILE()`.
  ```sql
  SELECT Name, Salary, ROW_NUMBER() OVER (ORDER BY Salary DESC) AS Rank
  FROM Employees;
  ```

#### **1.10 Result Bifurcation Using `GROUP BY` and `CASE WHEN`**
- **GROUP BY**:
  ```sql
  SELECT Department, COUNT(*) AS EmployeeCount
  FROM Employees
  GROUP BY Department;
  ```
- **CASE WHEN**:
  ```sql
  SELECT Name,
  CASE 
    WHEN Salary > 50000 THEN 'High'
    ELSE 'Low'
  END AS SalaryBracket
  FROM Employees;
  ```

---

### **2. Complex Procedures**

#### **2.1 Multiple Parameters with Output, XML, JSON**
- **Stored Procedure with Multiple Parameters and Output Parameter**:
  ```sql
  CREATE PROCEDURE GetEmployeeDetails
  @EmployeeID INT,
  @EmployeeName NVARCHAR(50) OUTPUT
  AS
  BEGIN
    SELECT @EmployeeName = Name FROM Employees WHERE ID = @EmployeeID;
  END;
  ```
- **Stored Procedure with XML Parameter**:
  ```sql
  CREATE PROCEDURE InsertEmployeeXML
  @EmployeeData XML
  AS
  BEGIN
    INSERT INTO Employees (ID, Name)
    SELECT T.c.value('@id', 'INT'), T.c.value('@name', 'NVARCHAR(50)')
    FROM @EmployeeData.nodes('/root/employee') AS T(c);
  END;
  ```
- **Stored Procedure with JSON Parameter**:
  ```sql
  CREATE PROCEDURE InsertEmployeeJSON
  @EmployeeData NVARCHAR(MAX)
  AS
  BEGIN
    INSERT INTO Employees (ID, Name)
    SELECT value.id, value.name
    FROM OPENJSON(@EmployeeData) WITH (id INT, name NVARCHAR(50)) AS value;
  END;
  ```

#### **2.2 Exception Handling and Error Catching**
- **TRY...CATCH Block**:
  ```sql
  BEGIN TRY
    -- Code that might cause an error
    SELECT 1 / 0;
  END TRY
  BEGIN CATCH
    -- Error handling code
    SELECT ERROR_MESSAGE() AS ErrorMessage;
  END CATCH;
  ```

#### **2.3 SET Environmental Variables**
- **Setting Variables**:
  ```sql
  DECLARE @MyVar INT = 10;
  SET @MyVar = 20;
  SELECT @MyVar;
  ```

#### **2.4 Calling Sub-Procedures**
- **Calling Another Procedure**:
  ```sql
  EXEC SubProcedureName @Parameter1 = Value1, @Parameter2 = Value2;
  ```

#### **2.5 Using Cursors

**
- **Cursor Example**:
  ```sql
  DECLARE @EmployeeID INT;
  DECLARE EmployeeCursor CURSOR FOR
    SELECT ID FROM Employees;

  OPEN EmployeeCursor;
  FETCH NEXT FROM EmployeeCursor INTO @EmployeeID;

  WHILE @@FETCH_STATUS = 0
  BEGIN
    -- Process each row
    FETCH NEXT FROM EmployeeCursor INTO @EmployeeID;
  END;

  CLOSE EmployeeCursor;
  DEALLOCATE EmployeeCursor;
  ```

#### **2.6 CRUD Operations**
- **Basic CRUD Operations**:
  - **Create**:
    ```sql
    INSERT INTO Employees (ID, Name, Salary) VALUES (1, 'John', 50000);
    ```
  - **Read**:
    ```sql
    SELECT * FROM Employees WHERE ID = 1;
    ```
  - **Update**:
    ```sql
    UPDATE Employees SET Salary = 60000 WHERE ID = 1;
    ```
  - **Delete**:
    ```sql
    DELETE FROM Employees WHERE ID = 1;
    ```

---

### **3. User Defined Functions**

#### **3.1 Table-Valued Functions**
- **Inline Table-Valued Function**:
  ```sql
  CREATE FUNCTION GetEmployeesByDepartment(@Department NVARCHAR(50))
  RETURNS TABLE
  AS
  RETURN (SELECT * FROM Employees WHERE Department = @Department);
  ```

#### **3.2 Scalar Functions**
- **Scalar Function Example**:
  ```sql
  CREATE FUNCTION GetEmployeeSalary(@EmployeeID INT)
  RETURNS INT
  AS
  BEGIN
    DECLARE @Salary INT;
    SELECT @Salary = Salary FROM Employees WHERE ID = @EmployeeID;
    RETURN @Salary;
  END;
  ```

---

### **4. Views**

#### **4.1 Complex Views**
- **Creating a Complex View**:
  ```sql
  CREATE VIEW EmployeeDepartmentView
  AS
  SELECT e.Name, d.DepartmentName
  FROM Employees e
  INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;
  ```

#### **4.2 View Permissions**
- **Granting Permissions**:
  ```sql
  GRANT SELECT ON EmployeeDepartmentView TO UserName;
  ```

#### **4.3 Indexed Views**
- **Creating an Indexed View**:
  ```sql
  CREATE VIEW IndexedEmployeeView WITH SCHEMABINDING AS
  SELECT DepartmentID, COUNT_BIG(*) AS EmployeeCount
  FROM dbo.Employees
  GROUP BY DepartmentID;

  CREATE UNIQUE CLUSTERED INDEX IX_IndexedEmployeeView ON IndexedEmployeeView (DepartmentID);
  ```

---

### **5. Triggers**

#### **5.1 After and Before Triggers**
- **After Trigger**:
  ```sql
  CREATE TRIGGER trgAfterInsert ON Employees
  AFTER INSERT
  AS
  BEGIN
    -- Trigger logic
  END;
  ```
- **Instead of Trigger**:
  ```sql
  CREATE TRIGGER trgInsteadOfInsert ON Employees
  INSTEAD OF INSERT
  AS
  BEGIN
    -- Trigger logic
  END;
  ```

#### **5.2 Magic Tables**
- **Using Magic Tables** (`INSERTED`, `DELETED`):
  ```sql
  CREATE TRIGGER trgAfterUpdate ON Employees
  AFTER UPDATE
  AS
  BEGIN
    SELECT * FROM INSERTED; -- New data
    SELECT * FROM DELETED;  -- Old data
  END;
  ```

---

### **6. Query Hints**

#### **6.1 NoLock, Tablock, ForceIndex, UsingIndex, MAXRECURSION**
- **NoLock**:
  ```sql
  SELECT * FROM Employees WITH (NOLOCK);
  ```
- **Tablock**:
  ```sql
  SELECT * FROM Employees WITH (TABLOCK);
  ```
- **ForceIndex**:
  ```sql
  SELECT * FROM Employees WITH (INDEX(IndexName));
  ```
- **UsingIndex**:
  ```sql
  SELECT * FROM Employees WITH (INDEX(IndexName));
  ```
- **MAXRECURSION**:
  ```sql
  WITH RecursiveCTE AS (
    SELECT ... 
    UNION ALL
    SELECT ...
  )
  SELECT * FROM RecursiveCTE OPTION (MAXRECURSION 100);
  ```

---

### **7. Conditional Queries**

#### **7.1 IF Statement, CASE WHEN, WHILE Loop**
- **IF Statement**:
  ```sql
  IF (@Salary > 50000)
    SELECT 'High Salary';
  ELSE
    SELECT 'Low Salary';
  ```
- **CASE WHEN**:
  ```sql
  SELECT Name, 
  CASE 
    WHEN Salary > 50000 THEN 'High'
    ELSE 'Low'
  END AS SalaryBracket
  FROM Employees;
  ```
- **WHILE Loop**:
  ```sql
  DECLARE @Counter INT = 1;
  WHILE (@Counter <= 10)
  BEGIN
    PRINT @Counter;
    SET @Counter = @Counter + 1;
  END;
  ```

#### **7.2 COALESCE, STUFF, NullIf, IsNull, Exists, IN**
- **COALESCE**:
  ```sql
  SELECT COALESCE(NULL, 'DefaultValue');
  ```
- **STUFF**:
  ```sql
  SELECT STUFF('abcdef', 2, 3, 'xyz');
  ```
- **NullIf**:
  ```sql
  SELECT NullIf(10, 10);
  ```
- **IsNull**:
  ```sql
  SELECT ISNULL(NULL, 'DefaultValue');
  ```
- **Exists**:
  ```sql
  IF EXISTS (SELECT * FROM Employees WHERE Name = 'John')
    PRINT 'Exists';
  ```
- **IN**:
  ```sql
  SELECT * FROM Employees WHERE Department IN ('HR', 'IT');
  ```

#### **7.3 Dynamic Query with Parameters, Merge Statement**
- **Dynamic Query with Parameters**:
  ```sql
  DECLARE @SQL NVARCHAR(MAX) = 'SELECT * FROM Employees WHERE Name = @Name';
  EXEC sp_executesql @SQL, N'@Name NVARCHAR(50)', @Name = 'John';
  ```
- **Merge Statement**:
  ```sql
  MERGE INTO TargetTable AS target
  USING SourceTable AS source
  ON target.ID = source.ID
  WHEN MATCHED THEN 
    UPDATE SET target.Name = source.Name
  WHEN NOT MATCHED THEN
    INSERT (ID, Name) VALUES (source.ID, source.Name);
  ```

---

### **8. Performance Tuning**

#### **8.1 Indexes, Profiler, Activity Monitor, Execution Plan**
- **Clustered and Non-clustered Indexes**:
  ```sql
  CREATE CLUSTERED INDEX IX_Clustered ON Employees (ID);
  CREATE NONCLUSTERED INDEX IX_NonClustered ON Employees (Name);
  ```
- **Profiler**: Tool for monitoring T-SQL execution.
- **Activity Monitor**: Real-time monitoring tool for SQL Server.
- **Execution Plan**: Visual representation of query execution.
  ```sql
  SET SHOWPLAN_XML ON;
  GO
  -- Your query here
  SET SHOWPLAN_XML OFF;
  ```

#### **8.2 Eliminate Sub-Queries, Optimize Joins, CTE, Temp Tables**
- **Eliminate Sub-Queries**: Convert to joins where possible.
- **Optimize Joins**: Ensure indexed columns are used in joins.
- **Proper Use of CTE and Temp Tables**: Use CTE for recursive queries, temp tables for storing intermediate results.

---

These notes should give you a good starting point for each topic. Feel free to ask for more detailed explanations or examples on any specific point!