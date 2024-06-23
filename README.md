```
BEGIN
	CLASS Program
		Main METHOD
      VAR temperatures = INT ARRAY[SIZE: 5]
      VAR copied = INT ARRAY[SIZE: 5]
      VAR valuesEntered = 0
      WHILE valuesEntered < 5 THEN
        VAR salesperson = CONVERT TO INT(PROMPT USER("INPUT Temperature "))
        IF temperature < -30 or temperature > 130 THEN
          PRINT
          - "EXCEPTION Temperature {0} is invalid, Please enter a valid temperature between -30 and 130", temperature
          (SKIP TO NEXT ITERATION)
        
        temperatures AT INDEX [valuesEntered] = temperature;
        copied AT INDEX [valuesEntered] = temperature;
        INCREMENT valuesEntered
      
      
      SORT ARRAY (copied)
      VAR arraysEqual = true
      FOR int i = 0; i < copied.Length; i++ ITER
        IF copied AT INDEX [i] != temperatures AT INDEX [i] THEN
          arraysEqual = false
      
      IF arraysEqual THEN
        PRINT
          - "OUTPUT Getting Warmer"
        
      ELSE THEN
        REVERSE ARRAY (copied)
        arraysEqual = true
        FOR int i = 0; i < copied.Length; i++ ITER
          IF copied AT INDEX [i] != temperatures AT INDEX [i] THEN
            arraysEqual = false
        
        IF arraysEqual THEN
          PRINT
            - "OUTPUT Getting Colder"
        ELSE THEN
          PRINT
            - "OUTPUT It's a mixed bag"
      
      
      PRINT
        - "OUTPUT 5-day Temperature ["
      FOR var i = 0; i < temperatures.Length; i++ ITER
        IF(i equals temperatures.Length - 1 THEN
          PRINT
            - temperatures AT INDEX [i]
        ELSE THEN
          PRINT FORMAT
            - "{0}, ", temperatures AT INDEX [i]
      
      PRINT
        - "]"
  
      VAR sum = 0.0
      FOREACH var temp in temperatures ITER
        sum+=temp
      PRINT FORMAT
        - "OUTPUT Average Temperature is {0} degrees", sum/temperatures.Length

		END Main
	END Program
END
```
