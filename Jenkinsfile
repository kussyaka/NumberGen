pipeline {
    agent any

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                sh 'ls -la'
                sh 'dotnet run'
                sh 'dotnet test'
            }
        }
    }
}
