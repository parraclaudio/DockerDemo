# DockerDemo

##### Publish the project

```
dotnet publish -c Release -o ./app/publish
```

##### Create a Docker image based on Dockerfile
```
docker build -t dockerdemoimage .
```

##### Create and start a Docker container based on our image (dockerdemoimage), in the specified port 8080
```
docker run -d -p 8080:80 --name dockerdemoapi dockerdemoimage
```

##### Check the page
http://localhost:8080/swagger
