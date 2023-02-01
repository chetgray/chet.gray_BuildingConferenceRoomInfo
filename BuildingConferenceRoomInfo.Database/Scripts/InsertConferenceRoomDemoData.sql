INSERT INTO [ConferenceRoom] (
    [Name]
    , [BuildingName]
    , [Phone]
    , [IsAVCapable]
    , [Capacity]
    )
SELECT t.*
FROM (
    SELECT 'Louisville (in the database) 101' AS [Name]
        , 'Louisville HQ' AS [BuildingName]
        , '(844) 492-9782 ext. 1' AS [Phone]
        , 0 AS [IsAVCapable]
        , 10 AS [Capacity]
    
    UNION ALL
    
    SELECT 'Louisville 201'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 2'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 'Louisville 301'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 3'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 'Louisville 401'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 4'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 'Chicago 101'
        , 'Chicago'
        , '(312) 858-1219 ext. 5'
        , 0
        , 11
    
    UNION ALL
    
    SELECT 'Chicago 201'
        , 'Chicago'
        , '(312) 858-1219 ext. 6'
        , 1
        , 12
    
    UNION ALL
    
    SELECT 'Chicago 301'
        , 'Chicago'
        , '(312) 858-1219 ext. 7'
        , 0
        , 15
    
    UNION ALL
    
    SELECT 'Chicago 401'
        , 'Chicago'
        , '(312) 858-1219 ext. 8'
        , 1
        , 30
    
    UNION ALL
    
    SELECT 'Denver 101'
        , 'Denver'
        , '(844) 555-9782 ext. 9'
        , 0
        , 10
    
    UNION ALL
    
    SELECT 'Denver 201'
        , 'Denver'
        , '(844) 555-9782 ext. 10'
        , 1
        , 20
    
    UNION ALL
    
    SELECT 'Denver 301'
        , 'Denver'
        , '(844) 555-9782 ext. 11'
        , 0
        , 25
    
    UNION ALL
    
    SELECT 'Denver 401'
        , 'Denver'
        , '(844) 555-9782 ext. 12'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 'Duluth 101'
        , 'Duluth'
        , '(770) 342-0200 ext. 13'
        , 0
        , 12
    
    UNION ALL
    
    SELECT 'Duluth 201'
        , 'Duluth'
        , '(770) 342-0200 ext. 14'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 'Duluth 301'
        , 'Duluth'
        , '(770) 342-0200 ext. 15'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 'Duluth 401'
        , 'Duluth'
        , '(770) 342-0200 ext. 16'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 'Lehi 101'
        , 'Lehi'
        , '(844) 555-2879 ext. 17'
        , 0
        , 12
    
    UNION ALL
    
    SELECT 'Lehi 201'
        , 'Lehi'
        , '(844) 555-2879 ext. 18'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 'Lehi 301'
        , 'Lehi'
        , '(844) 555-2879 ext. 19'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 'Lehi 401'
        , 'Lehi'
        , '(844) 555-2879 ext. 20'
        , 1
        , 40
    ) t
WHERE NOT EXISTS (
        SELECT 1
        FROM [ConferenceRoom]
        );
