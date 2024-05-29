import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewpointComponent } from './viewpoint.component';

describe('ViewpointComponent', () => {
  let component: ViewpointComponent;
  let fixture: ComponentFixture<ViewpointComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ViewpointComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewpointComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
