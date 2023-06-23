pipeline {
    agent any

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                sh 'ls -la'
                sh 'dotnet run --project ./ConsoleApp1'
                sh 'dotnet test'
            }
        }
    }
}
