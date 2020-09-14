# Student Log

## Overview

This repository serves as a log of work you've done and work you intend to do.
This is important for several reasons:

1. It serves as a way to track the history of your own work so you can review
   what you've done in the past
2. It  allows Mx. Collard to monitor your progress and attempt to help course
   correct as early as possible.
3. It provides practice for working with the command line, `git`, and
   [Markdown](https://guides.github.com/pdfs/markdown-cheatsheet-online.pdf)
4. It will provide a single place for Mx. Collard to distribute utility
   functions for you to use throughout the year.

## Project 1: Beginning a Log

### Overview

The first project is to fork this repository and create two log entries each
time you work on something for this class. The first log entry is a sign-on log
entry and should be created before you start working. A sign-on entry should
contain what you are setting out to accomplish. The second log entry is a
sign-off log entry and should be created when you're done working. It should
contain what you actually did, noting anything left over from the first entry
that was not finished. 

In addition to creating log entries, you will also be tasked with creating a
shell script that produces a template log entry for you based on the current
time stamp.

### Log Entry File Naming Convention

All log entries should be placed in the `log` folder and should be put in a file
named based on the date of the entry. For example, if you create a log on
September 12th, 2020, the name of the file that contains the entry should be
`2020-09-12.log`. Naming files in this manner will result in the files listing
in reverse chronological order when running the `ls` command; that is, the most
recent entry will appear first.

### Log Entry File Format

A single log file may contain multiple entries and should meet the following
criteria:

1. Each log should be written using Markdown (cheat sheet). 
2. Each log entry should appear in chronological order from top to bottom (e.g.
   the order in which it happened).
3. Each log entry should start with a header labeled with the time stamp that
   entry was written.
   * The time stamp format should match the results of running `date +"%A, %B
     %e, %Y %I:%M %p"`.
4. A sign-on log entry should contain a *Task List* list of items you are
   planning to work on. Finally, a sign-off message may optionally include a
   message about the work to be done.
5. A sign-off log entry should contain an *Task List* list of items that you
   accomplished as well as any items from your sign-on log entry that were not
   accomplished. Finally, a sign-off message may optionally include a message
   about the work that was done.
   * Each entry that was not accomplished should be accompanied with a note as
     to why it wasn't accomplished. This could be as simple as, No time,
     reprioritized, or no longer relevant.
6. All log files should have a maximum line length of 80 columns. This can be
   easily done in VSCode using
   [Rewrap](https://marketplace.visualstudio.com/items?itemName=stkb.rewrap)

#### Example Log File

`2020-09-13.log`
```
# Sunday, September 13, 2020 05:38 AM
[ ] Setup CSP GitHub Class
[ ] Create Repository for CSP Log project
[ ] Write README.md for first Log project
[ ] Add CSP Log project to Google Classroom

# Sunday, September 13, 2020 07:42 AM
[X] Setup CSP GitHub Class
[X] Create Repository for CSP Log project
[ ] Write README.md for first Log project - Started
[ ] Add CSP Log project to Google Classroom

Got hungry so I didn't finish. I'll be back later today. Finished writing the 
first few parts of the assignment. I need to go back and add a formatting rule
that says log files should not go past Col 80 and reference the VSCode plugin
"Rewrap" for automagically doing this for you.

# Sunday, September 13, 2020 12:30 PM
[ ] Add section on max line length for log entries
[ ] Add reference to Rewrap VSCode plugin
[ ] Add section on when to make commits 
[ ] Add section on utility scripts
[ ] Add section on grading
[ ] Add section on getting help
[ ] Add CSP Log project to Google Classroom

# Sunday, September 13, 2020 2:14 PM
[X] Add section on max line length for log entries
[X] Add reference to Rewrap VSCode plugin
[X] Add section on when to make commits 
[X] Add section on utility scripts
[X] Add section on grading
[X] Add section on getting help
[ ] Add CSP Log project to Google Classroom
```

### Branch / Commits / Pushing to Github

Your log entries should not be on the `main` branch. The first time you begin
work, you will want to move to a new branch. The branch name should be all
lowercase, should begin with the first letter of your first name and be followed
by your lastname. For example, Joseph Collard would become jcollard. To do this
*I* would run the following series of commands:

```
git checkout -b jcollard # This creates a new branch called jcollard and moves the repository to use it
git push -u origin jcollard # This pushes the new branch to Github
```

Note: You will need to change `jcollard` to be the correct name for your branch.

Each time you create an entry, you should add that entry to your branch, commit
it, and push it to GitHub.

In addition to committing each tim you create an entry, you *should* make
intermittent commits while working on other files within this repository.

### The start-entry.sh Script

To make writing log entries easier, you will create a script
`scripts/start-entry.sh` that will perform the following tasks:

1. Create a file, if one does not exist, that has the correct filename based on
   the current date.
2. Append the correct log file with a header containing the correct date format
   based on the current date.
3. Create a Task List containing 1 blank entry
4. Open the correct using VSCode

#### Getting Started

1. Create a new directory called `scripts`
2. Create a new file called `scripts/start-entry.sh` (use the `touch` command)
3. Add the scripts directory to the repository (`git add scripts`)
4. Open the script in VSCode by running `code scripts/start-entry.sh`

##### The Script Algorithm

1. The first line of the script should be `#!/bin/bash` this tells your shell
   that it should be executed using `bash`
2. Create a variable called `FILENAME` which contains the results of running
   `echo "$(date +'%Y-%m-%d').log"`
3. Use the `touch` command on `$FILENAME` (this creates a file if it doesn't
   exist)
4. Use the `echo` command to append (`>>`) `$FILENAME` with the string "# $(date
   +'%A, %B %e, %Y %I:%M %p'"
5. Use the `echo` command to append `$FILENAME` with the string "[ ]"
6. Finally, open `$FILENAME` using the `code` command

### Grading

Due date: Monday, September 28th, 2020 08:00 AM

As with all projects in this course, you will receive three equally weighted
grades: Computational Thinking, Computing Practice and Programming, and Skills
of a Student. Full details on these can be found on Power School.

*Note*: To receive full credit for the Skills of a Student category, you must
make commits through out the duration of this project. These should include log
entries for *ALL* work done in this class, not just on this project. For
example, if you work on Udacity Course Lession 5, that should be present in your
log.

### Getting Help

All questions should be posted to the class Piazza board. You are also
encouraged to help other students who post on Piazza (see: Skills of a Student -
#2: Work cooperatively and collaboratively with peers). When you post your
question, be sure to include as many details as possible for reproducing the
issue you're having. Screenshot are highly encouraged!

If you would like to meet to discuss synchronously, first, look at [Mx.
Collard's Calendar](http://tinyurl.com/mx-collard-calendar), then send them an
email with at least two proposed times you would like to meet.
