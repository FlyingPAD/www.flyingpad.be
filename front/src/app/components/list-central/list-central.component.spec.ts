import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListCentralComponent } from './list-central.component';

describe('ListCentralComponent', () => {
  let component: ListCentralComponent;
  let fixture: ComponentFixture<ListCentralComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListCentralComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ListCentralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
