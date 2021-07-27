# API Testing using Karate Framework
## What is Karate Framework?
Karate is open source tool which is used to test API. Even UI testing can be done using Karate framework.  Karate framework is an extension of Cucumber frameworks, obviously follows the behavior-driven development (BDD) and test cases written in Gherkin.
## About Gherkin
Gherkin is a human readable language created 	especially for behavior descriptions. Gherkin is a line oriented language; each statement is separated by new line.

### Gherkin Syntax
```cucumber
Feature: Brief description about test. Just for reference.
Background:
  # Optional section, used to define common variable across scenarios

Scenario: Brief description about scenario. Just for reference
  # Scenario Steps, Input and Expected Result
  # Given Context / Input Data
  # When Event 
  # Then Expected Result
Scenario: Another scenario
  # Scenario Steps, Input and Expected Result
  # Given Context / Input Data
  # When Event 
  # Then Expected Result
```
Let us start with exmaple: 

```cucumber
Feature: Find the tallest

Scenario: Find the tallest
  # Given John height is 5 ft and Peter height is 6 ft
  # When Find the tallest button clicked 
  # Then John is taller
```
### Hello World!
Only brefied about Gherking langauage, Learn more about Gherkin langauge in [Gherkin Language](https://docs.behat.org/en/v2.5/guides/1.gherkin.html). Like learning any another language, we start with "Hello World!" program.  

```cucumber
Feature: Hello World!

Scenario: Hello World!
  * print "Hello World!"
```
 
Save the above content to "Welcome.feature" file in a temporary directory. 
### Environment
Now our first feature is ready, but how to run this feature file using Karate framwork. It can be done different ways: Maven, Gradle and Standalone. We will be using Gradle in this article.
#### Tools Required

* [JDK](https://www.oracle.com/ca-en/java/technologies/javase-jdk11-downloads.html)
* [Gradle](https://gradle.org/install/)
* 

