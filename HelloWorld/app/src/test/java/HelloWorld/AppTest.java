/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package HelloWorld;

import com.intuit.karate.junit5.Karate;

class AppTest {

    @Karate.Test
    Karate HelloWorld() {
        return Karate.run("HelloWorld").relativeTo(getClass());
    }

}