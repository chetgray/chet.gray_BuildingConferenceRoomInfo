INSERT INTO [Building] (
    [Id]
    , [Name]
    , [AddressStreet]
    , [AddressCity]
    , [AddressState]
    , [AddressZip]
    , [AddressCountry]
    , [MainPhone]
    , [FloorCount]
    , [ConferenceRoomCount]
    )
SELECT t.*
FROM (
    SELECT 1 [Id]
        , 'Louisville HQ' AS [Name]
        , '888 W Market St' AS [AddressStreet]
        , 'Louisville' AS [AddressCity]
        , 'KY' AS [AddressState]
        , '40202' AS [AddressZip]
        , 'United States' AS [AddressCountry]
        , '(844) 492-9782' AS [MainPhone]
        , 10 AS [FloorCount]
        , 4 AS [ConferenceRoomCount]
    
    UNION ALL
    
    SELECT 2
        , 'Chicago'
        , '1330 W Fulton St #300'
        , 'Chicago'
        , 'IL'
        , '60607'
        , 'United States'
        , '(312) 858-1219'
        , 9
        , 4
    
    UNION ALL
    
    SELECT 3
        , 'Denver'
        , '7900 E Union Ave #400'
        , 'Denver'
        , 'CO'
        , '80237'
        , 'United States'
        , '(844) 555-9782'
        , 8
        , 4
    
    UNION ALL
    
    SELECT 4
        , 'Duluth'
        , '2055 Sugarloaf Cir'
        , 'Duluth'
        , 'GA'
        , '30097'
        , 'United States'
        , '(770) 342-0200'
        , 7
        , 4
    
    UNION ALL
    
    SELECT 5
        , 'Lehi'
        , '1550 Digital Dr'
        , 'Lehi'
        , 'UT'
        , '84043'
        , 'United States'
        , '(844) 555-2879'
        , 6
        , 4
    ) t
WHERE NOT EXISTS (
        SELECT 1
        FROM [Building]
        );
