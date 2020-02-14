# Bottega Final Capstone, VB6 to Visual Studio 2019

This application calculates a bid for international aircraft delivery. It was written to be completely self-contained to allow pilots to create an accurate bid on the fly. It consists of three forms:

  1. Enter client info
  
  2. Calculate mileage by entering ICAOs (four letter airport codes) for each stop on the flight.  Mileage is calculated with ICAO longitude and latitude info, which is stored within the app.
  
  3. Calculate fuel costs by entering aircraft model and anticipated fuel cost per gallon, calculate crew costs by entering Per Diem Rate, Per Diem Days, Crew Salaries for up to three crew members and return airfare for each crew member. add any miscellaneous charges (eg. emergency equipment, tanking, etc.), add insurance cost and automatically get a total for Insured Flight and Uninsured Flight. This gives the client a chance to compare our insurance vs. their insurance.
  
This app was originally written in Visual Basic 6 and uses graphics that I created in Photoshop. It had not been updated since right before the .NET Framework was implemented. 

There is quite a bit of redundant code due to the need to be self-contained and not implement any outer dependencies. If this was going to be put into production today, I would rebuild it with the ASP .NET framework, connect it to a database to pull the ICAO info and aircraft info from and implement the ability to print. Getting one page to print was actually the most challenging part of this program and did not translate well in Visual Studio 2019.

The exe file at https://github.com/maria72865/md-bottega-final-capstone-bid/tree/master/bin/app.publish will throw all kinds of red flags, but if you allow it to run, it functions beautifully.  It definitely adheres to Microsoft’s “It just works” credo…
