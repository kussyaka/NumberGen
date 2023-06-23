pipeline {
    agent any
    
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                sh 'dotnet build'
                sh 'dotnet test'
                sh 'ls -la'
            }
        }
    }
}
