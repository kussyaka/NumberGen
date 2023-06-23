pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:latest' 
        }
    }
environment {
   HOME = '/tmp'
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
