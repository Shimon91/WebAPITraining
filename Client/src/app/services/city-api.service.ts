import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CityApiService {

  constructor(private httpClient: HttpClient) { }

  public createCity(city: City): Observable<void> {

  }

  public getCityById(cityId: number): City {

  }

  public getCitiesByCountryId(countryId: number) {

  }

  public updateCityName(cityId: number, newCityName) {

  }
}
