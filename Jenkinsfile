pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:7.0' 
        }
    }
    
    stages {
        stage('Test') {
            steps {
                sh 'ls -la'
                sh 'dotnet --version'
                sh 'dotnet build'
                sh 'dotnet test'
            }
        }
    }
}
