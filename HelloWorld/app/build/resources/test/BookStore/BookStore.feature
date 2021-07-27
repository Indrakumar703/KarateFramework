Feature: Test Book Store

Background:
    * url 'http://localhost:5000/BookStore/'
    * configure report = { shouldLog : true, showAllSteps : true }

Scenario: Create Book
    * def model = 
    """
    {
        "Title" : "Title1",
        "BookNumber" : "Book1",
        "Category" : "Cateogry1",
        "Languauge" : "English",
        "Author" : "Author1"
    }
    """

    Given path 'CreateBook'
    And request model
    When method post
    Then status 200

  Scenario: Retrieve Book
    
    Given path 'RetrieveBook'
    And param bookNumber = 'Book1'
    When method get
    Then status 200

  Scenario: Update Book
    * def model = 
    """
    {
        "Title" : "Title Updated",
        "BookNumber" : "Book1",
        "Category" : "Cateogry Updated",
        "Languauge" : "English",
        "Author" : "Author Updated"
    }
    """

    Given path 'UpdateBook'
    And request model
    When method put
    Then status 200

  Scenario: Delete Book

    Given path 'DeleteBook'
    And param bookNumber = 'Book1'
    When method delete
    Then status 200

