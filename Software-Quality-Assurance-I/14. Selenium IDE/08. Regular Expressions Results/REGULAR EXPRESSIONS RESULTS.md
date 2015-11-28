### Regular Expressions Results
If you use the following regular expressions what will be a possible result?
</br>
<img src="images/regExp.png" />

 Regular Expression | Result (Xpath)|
| ------------- |:-------------:|
| [A-z0-9._%+-]+@[A-z0-9.-]+.[A-z]{2,4} || /html/body/div/div[5]/div[1]/a AND /html/body/div/div[3]
|\\(+[0-9]{2}+\)+\s+[0-9]{3}+\s+[0-9]{4}|| /html/body/div/div[3] AND /html/body/div/div[5]/div[2]
|\d{4}\s\d{3}\s\d{2} || /html/body/div/div[5]/div[2]
| \d{2}-\d{2}-\d{4} || /html/body/div/div[5]/div[2] 
| \w+\,+\s+\d{1,2}\s+\w+\s+\d{4}\,+\s+\d{2}\:\d{2}\:\d{2} || /html/body/div/div[5]/div[2]

Use these expressions to verify that text is present in the html file Index.html. Prepare Selenium Test Case with verifications.



