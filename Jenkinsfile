pipeline {
    agent any
    triggers {
        cron('* * * * *')
    }

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                sh 'ls -la'
            }
        }
    }
}
