/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package BookStore;

import com.intuit.karate.junit5.Karate;

class BookStoreTest {

    @Karate.Test
    Karate BookStoreTestCRUD() {
        return Karate.run("BookStore").relativeTo(getClass());
    }

}
