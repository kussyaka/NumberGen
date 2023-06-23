pipeline {
    agent any
    
    stages {
        stage('Test') {
            steps {
                echo 'Hello World'
                sh 'dotnet build'
                sh 'dotnet test'
            }
        }
    }
}
