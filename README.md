# [swagger-typescript-api](https://github.com/acacode/swagger-typescript-api) 자동생성도구 예제

아래와 같은 순서로 테스트 가능

1. backend 폴더에서 아래 명령어로 dotnet web api를 실행한다. (사전에 dotnet이 설치되어 있어야 함)
```shell
dotnet run --launch-profile https
```

2. frontend 폴더에서 아래 명령어로 WeatherApi 클래스 자동 생성 (예제는 이미 생성되어 있음)
```shell
npx swagger-typescript-api -p https://localhost:7032/swagger/v1/swagger.json -o ./src/lib -n weatherApi.ts --api-class-name WeatherApi
```

3. frontend 폴더에서 svelte 개발서버 실행
```
npm run dev
```
