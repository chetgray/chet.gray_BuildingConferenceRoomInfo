INSERT INTO [ConferenceRoom] (
    [Id]
    , [Name]
    , [BuildingName]
    , [Phone]
    , [IsAVCapable]
    , [Capacity]
    )
SELECT t.*
FROM (
    SELECT 1 AS [Id]
        , 'Louisville 101' AS [Name]
        , 'Louisville HQ' AS [BuildingName]
        , '(844) 492-9782 ext. 1' AS [Phone]
        , 0 AS [IsAVCapable]
        , 10 AS [Capacity]
    
    UNION ALL
    
    SELECT 2
        , 'Louisville 201'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 2'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 3
        , 'Louisville 301'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 3'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 4
        , 'Louisville 401'
        , 'Louisville HQ'
        , '(844) 492-9782 ext. 4'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 5
        , 'Chicago 101'
        , 'Chicago'
        , '(312) 858-1219 ext. 5'
        , 0
        , 11
    
    UNION ALL
    
    SELECT 6
        , 'Chicago 201'
        , 'Chicago'
        , '(312) 858-1219 ext. 6'
        , 1
        , 12
    
    UNION ALL
    
    SELECT 7
        , 'Chicago 301'
        , 'Chicago'
        , '(312) 858-1219 ext. 7'
        , 0
        , 15
    
    UNION ALL
    
    SELECT 8
        , 'Chicago 401'
        , 'Chicago'
        , '(312) 858-1219 ext. 8'
        , 1
        , 30
    
    UNION ALL
    
    SELECT 9
        , 'Denver 101'
        , 'Denver'
        , '(844) 555-9782 ext. 9'
        , 0
        , 10
    
    UNION ALL
    
    SELECT 10
        , 'Denver 201'
        , 'Denver'
        , '(844) 555-9782 ext. 10'
        , 1
        , 20
    
    UNION ALL
    
    SELECT 11
        , 'Denver 301'
        , 'Denver'
        , '(844) 555-9782 ext. 11'
        , 0
        , 25
    
    UNION ALL
    
    SELECT 12
        , 'Denver 401'
        , 'Denver'
        , '(844) 555-9782 ext. 12'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 13
        , 'Duluth 101'
        , 'Duluth'
        , '(770) 342-0200 ext. 13'
        , 0
        , 12
    
    UNION ALL
    
    SELECT 14
        , 'Duluth 201'
        , 'Duluth'
        , '(770) 342-0200 ext. 14'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 15
        , 'Duluth 301'
        , 'Duluth'
        , '(770) 342-0200 ext. 15'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 16
        , 'Duluth 401'
        , 'Duluth'
        , '(770) 342-0200 ext. 16'
        , 1
        , 40
    
    UNION ALL
    
    SELECT 17
        , 'Lehi 101'
        , 'Lehi'
        , '(844) 555-2879 ext. 17'
        , 0
        , 12
    
    UNION ALL
    
    SELECT 18
        , 'Lehi 201'
        , 'Lehi'
        , '(844) 555-2879 ext. 18'
        , 1
        , 15
    
    UNION ALL
    
    SELECT 19
        , 'Lehi 301'
        , 'Lehi'
        , '(844) 555-2879 ext. 19'
        , 0
        , 20
    
    UNION ALL
    
    SELECT 20
        , 'Lehi 401'
        , 'Lehi'
        , '(844) 555-2879 ext. 20'
        , 1
        , 40
    ) t
WHERE NOT EXISTS (
        SELECT 1
        FROM [ConferenceRoom]
        );
