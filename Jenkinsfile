pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:7.0' 
        }
    }
    
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
