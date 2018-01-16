The UI controls (Progress Bar, Cancel Button) behave somewhat arbitrarily in some cases because threads get out of sync in some configurations. When you press cancel, it won't cancel right away, it will cancel on the multiples of 20% (basically we are doing 5 matrix multiplications and then averaging out. So the cancel button will work at the end of a matrix multiplication). 

For logging, I have used log4net (XML configuration file). I have used Rolling File Appender with 5 files limit, each of 10 MB. The main difference between a normal text file appender and a rolling file appender is that rolling file doesn't keep on growing forever like a normal text file. After the specified limit is crossed, rolling file makes a new file and start writing to that and drops the older information if necessary. So in my case, I have decided to store 50 MB worth of logs which is more than enough for our purpose. I have set the level to DEBUG which will gives us all the messages (info, warnings, errors etc)

I have attached a sample log file. To see logging in action, check "Logs" folder in your drive D. Or you can change this address from the App.config file in the appender subsection. 

