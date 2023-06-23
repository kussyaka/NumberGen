pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:latest' 
        }
    }
    triggers {
        cron('H 12 * * *')
    }
    environment {
        HOME = '/tmp'
    } 
    
    stages {
        stage('Test') {
            steps {
            sh 'ls -la'
            sh 'dotnet build'
            sh 'dotnet test'
         }
    }
}
}
