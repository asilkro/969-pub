C969 - Customer Scheduling Software
Last updated: 01/08/2023

Notes for Assessor:
1) The log file (AppLog.txt) capturing login attempts will be found in the root program directory once generated.

2) Supported locales/languages are US-English & DE-German.

3) Business (valid) hours are defined as seven days a week from 0900 to 2100 local time.

4) The DB Time Zone is being treated as UTC - given the premise of the assignment
(the business has locations across international borders and in multiple time zones), this seemed a reasonable assumption.

5) Appointment reminder alerts are generated automatically on logon but can be triggered manually by entering the userId into the the box corresponding to the
"Upcoming Appointments for User" button.

6) The populateDB_modified.sql file can be used to populate some initial data into the DB but may conflict with existing data.
To help demonstrate the logging requirement, a second `eval` user is added by this script.