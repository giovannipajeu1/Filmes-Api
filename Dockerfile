FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY . . 

EXPOSE 5039

CMD [ "dotnet", "build" ]

ENTRYPOINT [ "dotnet", "run" ]