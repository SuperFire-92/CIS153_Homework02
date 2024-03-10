# CIS153_Homework02
 User Database

This app allows an admin to see all of the users in a made up database. The admin can add new users to it during runtime,
but these will not persist once the app is closed. A user is made up of a username, first name, last name, email, and password.
The program will prevent you from submitting a user if it reuses a username, does not have a password that is at least 8 characters
long and includes a number, does not have two matching passwords, or if any field is empty. Once a user is submitted, all of the
fields are emptied and the user display is refreshed, allowing you to view the new user and enter more users.